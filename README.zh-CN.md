# Extreme Injector Ex

[![版本](https://img.shields.io/badge/version-3.7.4-1677c8)](./version)
[![CI](https://github.com/Caritusy/ExtremeInjectorEx/actions/workflows/ci.yml/badge.svg)](https://github.com/Caritusy/ExtremeInjectorEx/actions/workflows/ci.yml)
[![Release](https://img.shields.io/github/v/release/Caritusy/ExtremeInjectorEx)](https://github.com/Caritusy/ExtremeInjectorEx/releases/latest)
![平台](https://img.shields.io/badge/platform-Windows-0078d4)
![框架](https://img.shields.io/badge/.NET_Framework-4.8-512bd4)

[English](./README.md) | **简体中文**

Extreme Injector Ex 是 Extreme Injector 3.7.3 的持续维护与演进版本，面向 Windows 平台。项目虽然起步于源码恢复，但现在已经成为一套结构化应用：具有现代化双语 GUI、完整命令行接口、经过加固的注入与 PE 处理流程、便携式单文件分发，以及不再需要穿越反编译控制流噪声的可维护源码。

仓库会在恢复运行时仍然必要的地方保留兼容行为，但不再把恢复出来的程序布局当成新代码必须遵循的架构。当前开发以职责明确的应用层、表现层、注入服务、PE 服务、本地化服务和平台服务为边界。

> [!WARNING]
> 本软件只能用于你拥有或已获得明确测试授权的程序。未经许可向第三方进程注入代码，可能违反软件许可、安全策略或适用法律。

## 当前能力

| 领域 | 当前实现 |
| --- | --- |
| 使用体验 | 支持 DPI 的 WinForms GUI、固定且一致的窗口布局、英语与简体中文，以及系统语言自动检测 |
| 自动化 | 通过 `-c` 或 `--cli` 启用的一等命令行接口，具有确定的退出码，并覆盖全部可持久化设置 |
| 注入方式 | 标准注入（`LoadLibrary`）、线程劫持、`LdrLoadDll`、`LdrLoadDll Stub` 和 Manual Map |
| Manual Map | 导入与 API Set 解析、基址重定位、TLS 回调、按内存页规划保护属性、指令缓存刷新和异常支持路径 |
| PE 处理 | PE32/PE32+ 头、导入、导出、重定位、TLS、资源、CLR 元数据目录、有效性检查和可选 DLL 混淆 |
| 进程工具 | 进程选择、模块快照、远程内存访问、导出函数调用和进程检查 |
| 分发 | 运行时包依赖与本地化资源嵌入单个可移动 EXE |
| 可靠性 | 每用户单一 GUI 实例、重复启动时前置已有窗口、设置原子写入和 CLI 独立设置文件 |
| 可维护性 | 轻量组合入口、独立 GUI/CLI 宿主、语义化类型与成员名称，以及 `src` 下的结构化控制流 |

## 环境要求

### 运行

- Windows 10 或 Windows 11。
- .NET Framework 4.8。
- 当操作需要访问其他进程时，使用管理员权限运行。
- DLL 与目标进程的体系结构必须匹配。

### 构建

- Visual Studio 2022 或 Build Tools 2022。
- .NET Framework 4.8 Developer Pack。
- .NET 10 SDK（固定的构建工具链；应用运行时仍以 .NET Framework 4.8 为目标）。

## 构建项目

```powershell
git clone https://github.com/Caritusy/ExtremeInjectorEx.git
Set-Location .\ExtremeInjectorEx
.\build.ps1 -Platform AnyCPU -Configuration Release
```

统一构建入口会恢复依赖、构建应用、运行自动化测试、检查英文与简体中文 CLI 启动，并输出 EXE 的 SHA-256。使用 `-Platform x86` 或 `-Platform x64` 可以进行体系结构构建检查，详见 [CONTRIBUTING.md](./CONTRIBUTING.md)。

Release 产物会写入源码树之外的目录：

```text
out/bin/ExtremeInjector/Release/net48/
```

中间文件位于 `out/obj/`。实际运行时只需要分发 `Extreme Injector.exe`；包依赖和本地化资源均已嵌入。生成的 `.pdb` 与 `.config` 文件不是正常运行所必需的依赖。

## 质量与发布

- Pull Request 和 `main` 会通过 GitHub Actions 在 Windows 上验证。
- CI 构建 AnyCPU、x86 与 x64 配置，并运行确定性测试和双语 CLI 冒烟检查。
- 后续 `v*` 标签必须与仓库版本一致并通过全部门禁，随后生成带版本号的 EXE、SHA-256 文件和构建来源证明。
- 兼容性结论遵循 [docs/COMPATIBILITY.md](./docs/COMPATIBILITY.md) 中的证据等级；构建成功不等于所有注入后端均已获得验证。
- 安全问题按照 [SECURITY.md](./SECURITY.md) 私下报告，发布维护者遵循 [docs/RELEASING.md](./docs/RELEASING.md)。

## GUI 使用方式

不带 CLI 参数启动 `Extreme Injector.exe`：

1. 选择目标进程。
2. 添加一个或多个 DLL。
3. 在“设置”中选择注入方式和可选行为。
4. 点击“注入”。

GUI 按 Windows 用户保持单实例。再次启动程序会恢复并前置已有窗口，从而避免两个实例并发写入同一份设置。每次启动使用不同窗口标题默认开启，也可以在设置中关闭。

界面默认跟随 Windows 显示语言。用户也可以明确选择英语或简体中文，切换后会立即生效。

## 命令行使用方式

只有提供 `-c` 或 `--cli` 时才会进入 CLI 模式。以下命令会显示当前构建版本的权威参数列表：

```powershell
& '.\Extreme Injector.exe' --cli --help
```

### 按 PID 选择进程

```powershell
& '.\Extreme Injector.exe' --cli `
  --pid 1234 `
  --dll 'D:\Modules\Example.dll' `
  --method standard
```

### 等待进程并使用 Manual Map

```powershell
& '.\Extreme Injector.exe' -c `
  --process Game.exe `
  --auto-inject `
  --wait-timeout 60 `
  --dll 'D:\Modules\Example.dll' `
  --method manual-map
```

进程名可以包含或省略 `.exe`，但必须唯一对应一个正在运行的进程。如果存在多个同名进程，命令会以退出码 `3` 结束并输出候选项：

```text
[0] 窗口标题 (1234)
[1] 另一个窗口 (5678)
```

请使用目标 PID 重新执行命令；程序不会在多个候选进程之间自行猜测。

### 多个 DLL 与导出函数

重复使用 `--dll` 可以添加多个模块。导出函数选项只作用于最近声明的 DLL：

```powershell
& '.\Extreme Injector.exe' --cli --pid 1234 `
  --dll 'D:\Modules\First.dll' `
  --export Initialize `
  --calling-convention stdcall `
  --arg uint32:1 `
  --dll 'D:\Modules\Second.dll'
```

调用约定支持 `stdcall`、`fastcall` 和 `cdecl`。导出函数参数类型支持 `ansi`、`unicode`、`byte`、`uint16`、`uint32`、`uint64` 和 `float`。

### 设置与非交互配置

CLI 参数覆盖注入行为、Manual Map 选项、DLL 混淆、延迟、本地化、界面颜色、警告确认、随机窗口标题和已保存 DLL 列表。除非指定 `--save-settings`，否则参数只在本次运行的内存中生效。

脚本或隔离工作流可以使用独立设置文件：

```powershell
& '.\Extreme Injector.exe' --cli `
  --settings '.\automation.xml' `
  --reset-settings `
  --language zh-CN `
  --no-random-title `
  --save-settings
```

CLI 注入可以与 GUI 同时运行。当 CLI 需要写入共享设置时，会使用与 GUI 相同的每用户锁；如果设置正被另一个实例占用，命令会以退出码 `7` 结束。

### 退出码

| 代码 | 含义 |
| ---: | --- |
| `0` | 操作成功完成 |
| `1` | 命令行参数无效 |
| `2` | 未找到目标进程或等待超时 |
| `3` | 进程名匹配到多个目标 |
| `4` | DLL 缺失、无效或未启用 |
| `5` | 需要管理员权限 |
| `6` | 注入或其他运行时操作失败 |
| `7` | 设置正被另一个实例占用 |
| `8` | 等待进程时被用户取消 |

## 设置与本地化

默认设置文件位于：

```text
%AppData%\ExtremeInjectorEx\settings.xml
```

设置先写入临时文件，再通过原子替换提交。如果当前用户尚无设置文件，程序会把 EXE 旁边的旧版 `settings.xml` 迁移到每用户目录。

程序自身的 GUI 与 CLI 文本保存在键集合一致的两份资源中：

```text
res/Localization/Strings.en.resx
res/Localization/Strings.zh-CN.resx
```

进程名、路径、DLL 名、导出函数名、窗口标题和操作系统错误详情等外部数据会保留原文，不参与翻译。

## 架构

```text
Program
  -> ApplicationHost
      -> GuiApplication / CliApplication
          -> 表现模型与协调器
              -> 注入、PE、设置、本地化和平台服务
                  -> Win32 互操作与恢复代码兼容适配器
```

仓库按职责组织：

```text
src/ExtremeInjector/
  Application/          组合入口、GUI/CLI 宿主、设置和应用模型
  Assembly/             AsmJit 与 BeaEngine 集成
  Collections/          内部集合实现
  Compression/          嵌入资源解压
  Injection/            注入后端、Manual Map 和远程进程服务
  Interop/              Win32 契约与原生结构
  Localization/         语言选择与本地化文本访问
  PortableExecutable/   PE 模型、读取、写入和转换
  Runtime/              启动支持与恢复代码兼容适配器
  UI/                   WinForms 视图与通用控件
  Utilities/            小型通用辅助功能
res/                    应用、窗体、嵌入数据和本地化资源
tests/                  确定性单元测试与解析器回归测试
docs/                   兼容性与发布维护指南
.github/                CI、依赖更新与贡献模板
out/                    本地构建产物，不提交到仓库
```

修改启动流程、注入、Manual Map、PE 解析或恢复代码兼容层前，请先阅读 [ARCHITECTURE.md](./ARCHITECTURE.md)。`Program.Main` 只承担组合入口职责，窗体只作为视图，注入和系统行为应放入独立服务。

## 开发状态

- 维护源码中的控制流混淆和反编译器生成 `goto` 图已经清除。
- 普通的数字类型名和成员名已经恢复为语义名称。二进制桩数据与兼容适配器仍属于特殊迁移区域，只应在具备针对性回归方案时修改。
- 常规应用路径使用强类型构造；为保持原有行为，兼容运行时仍在部分位置使用动态 IL、程序集加载和元数据令牌解析。
- 因此，trimming、NativeAOT 和 WinFormsComInterop 目前都不是可直接接入的替换方案。必须先替换动态兼容链，再单独验证互操作行为。
- 设置、本地化资源、混淆预设和 PE 解析现在具有初始自动化回归测试；受控注入夹具是下一项验证里程碑。
- 本地开发与 CI 共用 `build.ps1`。修改注入、PE 解析、嵌入依赖、设置或本地化后必须通过这套门禁。
- 项目变化记录在 [CHANGELOG.md](./CHANGELOG.md)，贡献规则位于 [CONTRIBUTING.md](./CONTRIBUTING.md)。

## 项目历史

Extreme Injector 最初由 **master131** 创建。Extreme Injector Ex 3.7.4 从可恢复的 3.7.3 程序源码起步，此后已经针对可维护性进行了重新组织和大量重写。项目不声称能够还原已经丢失的私有源码、原始标识符、注释或原始工程结构。

## 许可

本仓库目前没有独立的许可证文件。请勿自行假定拥有原项目和各贡献者未明确授予的重新分发或代码复用权利；分发衍生构建前，应先确认并建立适用的许可条款。
