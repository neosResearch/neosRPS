# néosRPS — Remote Pilot Station

**néosRPS** is an open-source **Remote Pilot Station** developed by **néosResearch**.  
It provides a modular, extensible foundation for UAV command and control, combining the freedom of open-source development under the **GNU General Public License v3.0 (GPLv3)** with optional **commercial licensing** for proprietary integrations and enterprise applications.

---

## ✈️ Overview

néosRPS is designed to serve as a flexible and modern **Ground Control Station (GCS)** platform for unmanned systems.  
It emphasizes modularity, extensibility, and cross-platform support through a plug-in architecture that enables both open-source and commercial components to coexist.

Key design goals include:

- 🧩 **Modular architecture** — every subsystem (telemetry, mapping, video, mission planning) is implemented as a plug-in.
- 💻 **Cross-platform support** — built with .NET MAUI to run on Windows, macOS, and Linux (and eventually Android/iOS).
- 🔌 **Extensible API** — commercial partners can build proprietary integrations under separate licensing.
- 🛰️ **Open foundation** — community-driven enhancements via the GPLv3 license.

---

## 🧠 Project Vision

> To create a modern, modular, and secure Remote Pilot Station that unifies open innovation with commercial-grade extensibility.

néosRPS aims to provide an open foundation for research, education, and industry — while allowing enterprise partners to develop proprietary modules without compromising the openness of the core.

---

## 🧩 Architecture Overview

Remote Pilot Station
├── Core Framework (GPLv3)
│ ├── UI Shell
│ ├── Plugin Host
│ ├── Telemetry Services
│ └── Mission Management
│
├── Official néosPlug-ins (GPLv3)
│ ├── Flight Display
│ ├── Map Engine
│ ├── MAVLink Adapter
│
└── Partner Plug-ins (Commercial License)
├── AI Target Tracking
├── Video Stream Analysis
└── Enterprise Integration Modules

---

## ⚙️ Technology Stack

- **Framework:** .NET MAUI / C#  
- **UI Layer:** MAUI XAML + custom components  
- **Plugin System:** Runtime assembly discovery and registration  
- **Communication:** MAVLink, gRPC, WebSocket  
- **Operating Systems:** Windows, Linux, macOS (Android/iOS planned)

---

## 📜 Licensing

néosRPS is **dual-licensed** under the following terms:

1. **GNU General Public License v3.0 (GPLv3)**  
   - Allows free use, modification, and redistribution of the open-source version.  
   - Any distributed modifications must remain open-source under GPLv3.

2. **Commercial License (néosResearch)**  
   - For organizations wishing to develop **proprietary plug-ins**, integrations, or OEM deployments.  
   - Grants rights to link néosRPS with closed-source code.  
   - Includes access to technical support and custom development options.

For details, see the [LICENSE.txt](./LICENSE.txt) file.

To request a commercial license, contact:

> **néosResearch Licensing**  
> Email: [licensing@neosresearch.com](mailto:licensing@neosresearch.com)  
> Website: [https://www.neosresearch.com/licensing](https://www.neosresearch.com/licensing)

---

## 🤝 Contributing

Contributions are welcome!  
By submitting code, documentation, or assets, you agree that your contribution will be licensed under the terms of the **GNU General Public License v3.0 (GPLv3)** and may be incorporated into both the open-source and commercial versions of néosRPS.

See the forthcoming [CONTRIBUTING.md](./CONTRIBUTING.md) for details.

---

## 🧭 Roadmap

| Milestone | Description | Status |
|------------|--------------|--------|
| v0.1 | Core framework scaffolding (UI shell, plugin host) | 🚧 In Progress |
| v0.2 | MAVLink interface, telemetry visualization | ⏳ Planned |
| v0.3 | Video streaming and mission planning modules | ⏳ Planned |
| v1.0 | Cross-platform release with plugin SDK | 🔜 Targeted 2026 |

---

## 💬 Community and Support

- 🌐 Website: [https://www.neosresearch.com](https://www.neosresearch.com)
- 📧 Contact: [info@neosresearch.com](mailto:info@neosresearch.com)
- 🧑‍💻 Issues: [GitHub Issues](https://github.com/neosResearch/neosRPS/issues)
- 💬 Discussions: Coming soon on GitHub Discussions

---

## 🏷️ Copyright Notice

© 2025 néosResearch.  
All rights reserved.

néosRPS is provided under the terms of the GNU General Public License v3.0, with optional commercial licensing available from néosResearch.

---

