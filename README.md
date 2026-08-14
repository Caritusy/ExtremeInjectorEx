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
- 主窗口及设置、模块选项等窗口采用统一界面风格，并固定为不可调整大小的工具窗口布局。
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

## 开发说明

- 项目当前目标框架是 .NET Framework 4.8，而不是 NativeAOT。
- 普通应用路径已避免使用 `Activator.CreateInstance` 和字段反射进行注入器、PE 读取器及设置绑定；`Runtime` 中仍保留旧版启动保护所需的动态 IL、动态程序集加载和元数据令牌解析。
- 因此当前不能直接接入 WinFormsComInterop，也不能仅通过开启 trimming 或 NativeAOT 完成迁移。若迁移到现代 .NET，需要先替换 `DynamicMethod` / `Reflection.Emit`、`Assembly.Load*` 和动态方法解析链，再单独验证 COM 与 WinForms 行为。
- `Runtime/Recovered` 是仍待逐步语义化的兼容层。修改低级 PE、进程或汇编代码后，应至少完成一次 Release 构建，并使用真实的 x86/x64 DLL 做解析和注入前检查。

## 来源与版本

当前程序集版本为 3.7.4。原始 Extreme Injector 由 master131 开发；本仓库是其 3.7.3 程序的社区维护源码恢复版本，并不声称能够还原已丢失的原始私有命名、注释或工程布局。

仓库当前未附带独立许可证文件。分发或再利用前，请同时确认原始项目与本仓库贡献内容的授权条件。
