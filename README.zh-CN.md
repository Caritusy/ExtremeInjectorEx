# Extreme Injector Ex

[![版本](https://img.shields.io/badge/version-3.7.4-1677c8)](./version)
![平台](https://img.shields.io/badge/platform-Windows-0078d4)
![框架](https://img.shields.io/badge/.NET_Framework-4.8-512bd4)

[English](./README.md) | **简体中文**

Extreme Injector Ex 是一个持续维护的 Windows DLL 注入器，基于 Extreme Injector 3.7.3 的可恢复源码构建。本仓库将恢复出的代码重新组织为可维护、可构建的工程，并继续完善现代化界面、PE 解析、双语本地化、单文件便携分发和可用于自动化的命令行模式。

> [!WARNING]
> 仅可将本软件用于你拥有或已获得明确测试授权的程序。向第三方进程注入代码可能违反软件许可、安全策略或当地法律。

## 主要特性

- 支持标准方式（`LoadLibrary`）、线程劫持、`LdrLoadDll`、`LdrLoadDll Stub` 和 Manual Map 注入。
- 支持解析 PE32 与 PE32+ 的导入、导出、重定位、TLS、资源和 CLR 目录。
- 注入前检查目标进程与 DLL 的体系结构是否匹配。
- 可配置自动注入、注入延迟、PE 头擦除、模块隐藏和 DLL 混淆。
- 支持调用导出函数，并可指定调用约定和类型化参数。
- 提供统一、支持高 DPI 的 WinForms 界面，内置英语和简体中文。
- 默认跟随系统语言，也可即时切换并持久保存语言选择。
- 每个 Windows 用户只运行一个 GUI 实例；再次启动会恢复并前置现有窗口。
- 通过 `-c` 或 `--cli` 提供完整命令行功能，覆盖所有可持久化设置。
- 运行时依赖和本地化资源均嵌入主程序，构建出的 EXE 可单独复制运行。

## 环境要求

### 运行

- Windows 10 或 Windows 11。
- .NET Framework 4.8。
- 注入操作需要访问目标进程时，必须以管理员身份运行。
- 目标进程与 DLL 的体系结构必须匹配。

### 构建

- Visual Studio 2022 或 Build Tools 2022。
- .NET Framework 4.8 Developer Pack。
- 能够构建 SDK 风格 `net48` 项目的 .NET SDK。

## 从源码构建

克隆仓库后，在仓库根目录运行：

```powershell
dotnet restore .\ExtremeInjectorEx.sln
dotnet build .\ExtremeInjectorEx.sln -c Release
```

Release 输出目录为：

```text
out/bin/ExtremeInjector/Release/net48/
```

所有中间文件都存放在 `out/obj/`。构建产物、本地设置、测试结果和 IDE 状态均不会提交到 Git。

## GUI 快速上手

正常运行 `Extreme Injector.exe` 即可打开图形界面：

1. 选择目标进程。
2. 添加一个或多个 DLL。
3. 在“设置”中选择注入方式和可选行为。
4. 点击“注入”。

GUI 按 Windows 用户保持单实例。再次启动程序不会创建第二个设置写入进程，而是恢复并前置已有主窗口。

设置文件保存在：

```text
%AppData%\ExtremeInjectorEx\settings.xml
```

设置写入采用临时文件和原子替换。程序目录中发现的旧版设置会迁移到当前用户目录。

### 便携分发

运行时只需要 `Extreme Injector.exe`。构建生成的 `.config` 和 `.pdb` 属于构建或调试辅助文件，并非运行依赖。

## 命令行模式

使用 `-c` 或 `--cli` 启用命令行模式。正常启动 GUI 时不会显示控制台窗口；在 CLI 模式下，它会像普通命令行程序一样等待完成并返回退出码。

查看当前构建版本的权威参数列表：

```powershell
& '.\Extreme Injector.exe' --cli --help
```

### 选择目标

按进程 ID 注入 DLL：

```powershell
& '.\Extreme Injector.exe' --cli --pid 1234 `
  --dll 'D:\Modules\Example.dll'
```

等待指定名称的进程启动，并使用 Manual Map：

```powershell
& '.\Extreme Injector.exe' -c --process Game.exe `
  --auto-inject --wait-timeout 60 `
  --dll 'D:\Modules\Example.dll' --method manual-map
```

进程名可以包含或省略 `.exe`，但最终必须唯一匹配。如果存在多个同名进程，CLI 不会猜测目标，而是以退出码 `3` 失败并输出候选项：

```text
[0] 第一个窗口标题 (1234)
[1] 第二个窗口标题 (5678)
```

请使用需要的 PID 重新执行命令。

### 多个 DLL 与导出函数

重复使用 `--dll` 可添加多个模块。`--export`、`--calling-convention` 和 `--arg` 只作用于最近添加的 DLL：

```powershell
& '.\Extreme Injector.exe' --cli --pid 1234 `
  --dll 'D:\Modules\First.dll' `
  --export Initialize --calling-convention stdcall --arg uint32:1 `
  --dll 'D:\Modules\Second.dll'
```

导出函数参数支持 `ansi`、`unicode`、`byte`、`uint16`、`uint32`、`uint64` 和 `float` 类型。

### 配置与持久化

GUI 中的所有用户可配置项都有对应 CLI 参数，包括：

- 注入方式、自动注入、成功后关闭和隐蔽注入。
- 注入前延迟和模块间延迟。
- PE 头擦除、模块隐藏和 Manual Map 高级选项。
- 混淆预设以及每一个独立混淆开关。
- 界面语言、随机窗口标题和三种界面颜色。
- 警告确认状态以及保存的 DLL 列表。

参数默认只影响本次运行；只有加入 `--save-settings` 才会持久保存。使用 `--settings <路径>` 可读写独立设置文件：

```powershell
& '.\Extreme Injector.exe' --cli --settings '.\automation.xml' `
  --reset-settings --language zh-CN --no-random-title --save-settings
```

CLI 注入可以与 GUI 同时运行。写入设置时会请求与 GUI 相同的每用户锁；如果另一个实例已占用设置，命令会以退出码 `7` 结束，而不会冒险产生冲突写入。

### 退出码

| 代码 | 含义 |
| ---: | --- |
| `0` | 操作成功完成。 |
| `1` | 命令行参数无效。 |
| `2` | 未找到目标进程。 |
| `3` | 进程名匹配到多个目标。 |
| `4` | DLL 缺失、无效，或没有已启用的 DLL。 |
| `5` | 需要管理员权限。 |
| `6` | 注入失败。 |
| `7` | 另一个实例正在占用设置锁。 |
| `8` | 等待进程的操作已取消。 |

## 本地化

界面默认跟随 Windows 显示语言：中文系统使用简体中文，其他系统使用英语。可以在“设置 → 外观与语言 → 界面语言”中即时切换。

项目自身的 GUI 和 CLI 文本都使用稳定资源键，英语和简体中文资源分别位于：

```text
res/Localization/Strings.en.resx
res/Localization/Strings.zh-CN.resx
```

两份资源必须保持完全相同的键集合。进程名、DLL 名、导出函数名、路径、窗口标题和操作系统错误详情来自外部，因此保持原文。

## 仓库结构

```text
ExtremeInjectorEx/
├─ src/ExtremeInjector/
│  ├─ Application/          程序入口、CLI、设置和应用模型
│  ├─ Assembly/             AsmJit 与 BeaEngine 互操作
│  ├─ Collections/          内部集合实现
│  ├─ Compression/          内嵌资源解压
│  ├─ Injection/            注入策略、远程进程和 Manual Map
│  ├─ Interop/              Win32 声明
│  ├─ Localization/         语言选择和资源访问
│  ├─ PortableExecutable/   PE32/PE32+ 数据结构与解析
│  ├─ Runtime/              启动、资源加载和恢复代码兼容层
│  ├─ UI/                   WinForms 窗口与控件
│  └─ Utilities/            通用辅助代码
├─ res/
│  ├─ Embedded/             受保护和压缩的运行时资源
│  ├─ Forms/                WinForms 资源
│  └─ Localization/         英语与简体中文文本
└─ out/                     本地构建输出（不提交）
```

## 开发说明

- 当前目标框架为 .NET Framework 4.8，并非 NativeAOT 应用。
- 普通应用路径已使用强类型工厂和绑定，避免通过反射构造核心对象；恢复代码兼容层仍依赖动态 IL、动态程序集加载和元数据令牌解析。
- 由于上述运行时要求，目前不能把 WinFormsComInterop、trimming 或 NativeAOT 当作直接替换方案。迁移到现代 .NET 前，需要先替换动态运行时链，再单独验证 WinForms 与 COM 行为。
- 受保护资源的逻辑名称是为兼容性保留的；修改前必须同步检查资源解析器。
- 修改 PE 解析、进程访问、程序集生成、内嵌依赖或本地化后，应至少完成一次 Release 构建和对应的回归测试。

## 项目历史

Extreme Injector 最初由 **master131** 开发。Extreme Injector Ex 3.7.4 是基于 3.7.3 可恢复程序源码维护的社区重建版本，不声称能够还原已经丢失的私有标识符、注释或原始工程布局。

## 许可证

本仓库目前没有附带独立许可证文件。请勿自行假定拥有重新分发或复用代码的权利；相关权限应以原项目和各贡献者实际授予的条款为准。分发衍生构建前，请先确认并建立明确的许可条件。
