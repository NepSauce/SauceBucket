Getting started

- Prereqs: .NET 9 SDK and MAUI workload (`dotnet workload install maui`).
- Clone and enter repo: `git clone <url> && cd SauceBucket`.
- Restore & build: `dotnet restore` then `dotnet build`.
- Run (Windows): `dotnet run -f net9.0-windows10.0.19041.0`.
- Run (Android emulator/device): `dotnet run -f net9.0-android`.
- Run (iOS on macOS): `dotnet run -f net9.0-ios` (requires Xcode/macOS).
- Run (Mac Catalyst on macOS): `dotnet run -f net9.0-maccatalyst` (requires macOS).
- Run (Tizen): `dotnet run -f net9.0-tizen` (requires Tizen workload/SDK).
- Build for multiple targets: `dotnet build -f <TFM>` per target or configure CI to build each target (use `-f` to specify target).

Key files
- `SauceBucket.csproj` — project config and app icon.
- `AppShell.xaml` — Shell and top-left icon behavior.
- `Resources/Styles/Colors.xaml` — change `Primary` color here.

Troubleshoot
- If workloads missing: `dotnet workload install maui`.
- Clean build issues: `dotnet clean` then `dotnet restore`.
