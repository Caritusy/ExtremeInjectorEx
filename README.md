# Extreme Injector Ex

Extreme Injector Ex 是一个面向 Windows 的 DLL 注入器，基于 Extreme Injector 3.7.3 的可用源码恢复版本继续维护。当前项目重点是保持既有功能兼容，同时逐步改善源码结构、PE 解析、设置存储和高 DPI 下的 WinForms 界面。

> 仅可对你拥有或已获得明确授权的软件进行测试。向第三方进程注入代码可能违反软件许可、安全策略或当地法律。

## 功能

- 支持 Standard / `LoadLibrary`、`LdrLoadDll`、`LdrLoadDll Stub`、线程劫持和 Manual Map 注入方式。
- 检查目标进程与 DLL 的 x86/x64 架构是否匹配。
- 解析 PE32 与 PE32+ 映像，包括导入、导出、重定位、TLS、资源和 CLR 目录。
- 支持自动注入、模块间延迟、PE 头擦除、模块隐藏和注入前加扰选项。
- 支持配置导出函数、调用约定和参数。
- 设置保存在 `%AppData%\ExtremeInjectorEx\settings.xml`，并兼容迁移旧版程序目录中的设置文件。
- NuGet 运行时依赖内嵌在主程序中，复制 `Extreme Injector.exe` 即可独立运行。
- 主窗口及设置、模块选项、进程选择、进程信息和高级选项窗口采用统一的现代界面；仅需要展示大量进程数据的“进程信息”窗口允许调整大小。
- GUI 按当前 Windows 用户保持全局单实例。重复启动只会恢复并前置已经打开的主窗口，避免多个进程同时覆盖同一份设置。
- 同一个 EXE 同时提供 CLI 模式，可按 PID 或进程名注入，并可配置 GUI 中的全部用户设置。
- 默认在每次启动时生成新的随机窗口标题；可在设置中关闭并恢复标准产品标题。
- 内置英语和简体中文界面；默认跟随 Windows 显示语言，也可在设置中即时切换并持久保存。

## 环境要求

- Windows 10/11 x64
- Visual Studio 2022 或 Build Tools 2022
- .NET Framework 4.8 Developer Pack
- 可构建 SDK 风格 `net48` 项目的 .NET SDK

注入器与目标模块的位数必须匹配；某些目标进程还需要以管理员身份运行注入器。

## 构建

在仓库根目录执行：

```powershell
dotnet restore .\ExtremeInjectorEx.sln
dotnet build .\ExtremeInjectorEx.sln -c Release
```

Release 输出位于：

```text
out/bin/ExtremeInjector/Release/net48/
```

所有中间文件位于 `out/obj/`。`out/` 已被 Git 忽略，不会再把 `bin`、`obj` 或本地运行产物混入源码目录。

发布或随身携带时只需要 `Extreme Injector.exe`；`.config` 和 `.pdb` 是构建辅助文件，不是运行依赖。

## 命令行模式

使用 `-c` 或 `--cli` 启用命令行模式。查看当前版本的完整参数表：

```powershell
& '.\Extreme Injector.exe' --cli --help
```

按 PID 注入一个 DLL：

```powershell
& '.\Extreme Injector.exe' --cli --pid 1234 --dll 'D:\Modules\Example.dll'
```

按进程名等待目标启动，并使用手动映射注入：

```powershell
& '.\Extreme Injector.exe' -c --process Game.exe --auto-inject --wait-timeout 60 `
  --dll 'D:\Modules\Example.dll' --method manual-map
```

`--dll` 可重复使用；紧随其后的 `--export`、`--calling-convention` 和 `--arg` 只作用于最近添加的 DLL：

```powershell
& '.\Extreme Injector.exe' --cli --pid 1234 `
  --dll 'D:\Modules\First.dll' --export Initialize --calling-convention stdcall --arg uint32:1 `
  --dll 'D:\Modules\Second.dll'
```

进程名必须唯一。如果匹配到多个进程，CLI 不会猜测目标，而是以退出码 3 失败并提供可重新指定的 PID：

```text
[0] First window title (1234)
[1] Second window title (5678)
```

注入方式、自动注入、关闭行为、隐蔽注入、延迟、注入后处理、Manual Map 高级选项、所有 DLL 混淆开关、界面语言、三种界面颜色、随机窗口标题、警告确认状态以及 DLL 列表均有对应参数。参数只影响本次进程；加入 `--save-settings` 才会持久保存。可使用 `--settings <路径>` 读取并写回独立设置文件，便于脚本隔离：

```powershell
& '.\Extreme Injector.exe' --cli --settings '.\automation.xml' `
  --reset-settings --language zh-CN --no-random-title --save-settings
```

帮助和设置写入可在普通终端中使用；真正执行注入时需要管理员权限。CLI 退出码如下：

| 退出码 | 含义 |
| ---: | --- |
| 0 | 操作成功 |
| 1 | 参数无效 |
| 2 | 未找到目标进程 |
| 3 | 进程名匹配到多个目标 |
| 4 | DLL 缺失或无可用 DLL |
| 5 | 需要管理员权限 |
| 6 | 注入失败 |
| 7 | 另一实例正在使用设置 |
| 8 | 等待过程被取消 |

## 项目结构

```text
ExtremeInjector/
├─ src/ExtremeInjector/
│  ├─ Application/          程序入口、设置和应用模型
│  ├─ Localization/         语言选择与本地化资源访问
│  ├─ UI/                   WinForms 窗口与控件
│  ├─ Injection/            注入策略、远程进程和 Manual Map
│  ├─ PortableExecutable/   PE32/PE32+ 数据结构与解析
│  ├─ Assembly/             AsmJit 与 BeaEngine 互操作层
│  ├─ Compression/          内嵌资源解压支持
│  ├─ Runtime/              启动、资源加载和恢复运行时
│  ├─ Interop/              Win32 互操作声明
│  ├─ Collections/          内部集合实现
│  ├─ Utilities/            通用辅助代码
│  └─ Properties/           程序集元数据
├─ res/
│  ├─ Forms/                WinForms 资源
│  ├─ Localization/         英语和简体中文文本资源
│  └─ Embedded/             运行时内嵌二进制资源
└─ out/                     本地构建输出（不提交）
```

`res/Embedded` 中的受保护资源使用可识别的物理文件名，但项目文件保留了旧版运行时依赖的逻辑资源名。修改这些逻辑名称前必须同步检查资源解析代码。

## 语言与本地化

首次运行及旧配置迁移后，界面语言默认为“跟随系统语言”：中文 Windows 使用简体中文，其他系统使用英语。可在“设置 → 外观与语言 → 界面语言”中选择“跟随系统语言”“英语”或“简体中文”；切换会立即生效，并写入 `%AppData%\ExtremeInjectorEx\settings.xml`。

所有项目自有的静态界面文案和通知文本都通过稳定资源键访问。英语与简体中文资源分别位于 `res/Localization/Strings.en.resx` 和 `res/Localization/Strings.zh-CN.resx`，两份资源必须保持完全相同的键集合。进程名、文件名、DLL 名、导出函数名及系统错误详情等外部内容保持原文。两套语言资源均直接嵌入主程序，不会产生需要随 EXE 分发的卫星程序集。

## 设置与单实例

默认设置文件位于 `%AppData%\ExtremeInjectorEx\settings.xml`，写入时使用同目录临时文件和原子替换。GUI 使用“当前用户全局互斥体 + 当前会话激活事件”：同一用户再次启动时不会创建第二个设置写入者，而是恢复最小化窗口并将其带到前台。CLI 注入可以独立运行；CLI 只有在显式使用 `--save-settings` 时才请求设置写入权，如果 GUI 正在使用默认设置，则以退出码 7 拒绝写入。

## 开发说明

- 项目当前目标框架是 .NET Framework 4.8，而不是 NativeAOT。
- 普通应用路径已避免使用 `Activator.CreateInstance` 和字段反射进行注入器、PE 读取器及设置绑定；`Runtime` 中仍保留旧版启动保护所需的动态 IL、动态程序集加载和元数据令牌解析。
- 因此当前不能直接接入 WinFormsComInterop，也不能仅通过开启 trimming 或 NativeAOT 完成迁移。若迁移到现代 .NET，需要先替换 `DynamicMethod` / `Reflection.Emit`、`Assembly.Load*` 和动态方法解析链，再单独验证 COM 与 WinForms 行为。
- `Runtime/Recovered` 是仍待逐步语义化的兼容层。修改低级 PE、进程或汇编代码后，应至少完成一次 Release 构建，并使用真实的 x86/x64 DLL 做解析和注入前检查。

## 来源与版本

当前程序集版本为 3.7.4。原始 Extreme Injector 由 master131 开发；本仓库是其 3.7.3 程序的社区维护源码恢复版本，并不声称能够还原已丢失的原始私有命名、注释或工程布局。

仓库当前未附带独立许可证文件。分发或再利用前，请同时确认原始项目与本仓库贡献内容的授权条件。
