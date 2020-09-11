# Plugin Sample

This is a simple plugin project containing a single service that sends a welcome message to any connecting players.

## Build and Run

Run `dotnet build` to build the sample. The binaries will be put into a plugin folder in the bin folder.

Copy this output into the "Plugins" folder of your NWN.Managed installation. The server directory should look like such:

```bash
├── NWN.Core.dll
├── NWN.Managed.dll
├── Plugins
│   ├── plugin-sample
│   │   ├── plugin-sample.dll
```