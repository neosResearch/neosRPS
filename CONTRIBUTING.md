# Contributing to néosRPS

Thank you for your interest in contributing to **néosRPS** — an open-source Remote Pilot Station developed by **néosResearch** (Leland Johnson).

We welcome contributions from the community, including code improvements, documentation updates, feature proposals, and bug reports.  
By contributing, you help advance a modern, modular, and extensible ground control ecosystem that unites open innovation with commercial-grade capability.

---

## ⚖️ Licensing and Contributor Agreement

### Dual-Licensing Model
néosRPS is distributed under a **dual-license model**:

1. **GNU General Public License v3.0 (GPLv3)** — for open-source use, modification, and redistribution.
2. **Commercial License** — offered by néosResearch for proprietary plug-ins, enterprise deployments, and OEM integration.

All community contributions are made under the **GPLv3** license **and** with the understanding that néosResearch may include them in both the open-source and commercial distributions of néosRPS.

### Contributor License Agreement (CLA)
By submitting a contribution (code, documentation, or other assets) to this repository, you agree that:

- You are the original author of your contribution or otherwise have the right to submit it.
- You grant néosResearch a **perpetual, worldwide, non-exclusive, royalty-free license** to use, modify, and distribute your contribution under both:
  - the terms of the **GNU GPLv3**, and  
  - the néosResearch **Commercial License**.
- You understand that néosResearch may offer commercial versions of néosRPS that include your contribution.

This ensures néosRPS remains open and sustainable while enabling commercial partners to adopt it legally and responsibly.

---

## 🧩 How to Contribute

### 1. Fork and Clone the Repository
```bash
git clone https://github.com/neosResearch/neosRPS.git
cd neosRPS
````

### 2. Create a Feature Branch

```bash
git checkout -b feature/your-feature-name
```

### 3. Make Your Changes

Follow the project’s coding conventions and architecture guidelines (see below).
Commit your work with clear, conventional commit messages:

```
feat(plugin): add telemetry overlay module
fix(ui): correct panel resizing on startup
docs(readme): clarify plugin SDK structure
```

### 4. Test and Verify

Ensure your changes:

* Build successfully on all supported platforms.
* Pass any available unit or integration tests.
* Follow style and naming conventions.

### 5. Submit a Pull Request

Push your branch to your fork and open a Pull Request (PR) to the `main` branch.

Your PR should include:

* A clear description of the change.
* Reference to any related issue (e.g., “Closes #42”).
* Confirmation that you agree to the contributor terms outlined in this file.

---

## 🧠 Code Style & Guidelines

* **Language:** C# (.NET 8 / MAUI)
* **Namespace Style:** File-scoped, braces retained for consistency.
* **Line Width:** 100 columns maximum.
* **Comments:** Use concise, functionality-oriented inline comments.
* **Formatting:** Run `.editorconfig` or `dotnet format` before committing.
* **Architecture:** Each functional area implemented as a plug-in (DLL), dynamically loaded at runtime.

---

## 🧾 Reporting Issues

If you encounter bugs or have suggestions for improvement:

* Open an [Issue](https://github.com/neosResearch/neosRPS/issues)
* Include clear reproduction steps and environment details.
* For security vulnerabilities, **do not** post publicly — email [Security@neosResearch.net](mailto:Security@neosResearch.net).

---

## 💬 Community and Communication

* **Website:** [https://www.neosResearch.net](https://www.neosResearch.net)
* **Email:** [Info@neosResearch.net](mailto:Info@neosResearch.net)
* **Issues:** [GitHub Issues](https://github.com/neosResearch/neosRPS/issues)
* **Discussions:** (coming soon)

---

## 🏷️ Legal Notice

© 2025 néosResearch (Leland Johnson). All rights reserved.

By contributing to néosRPS, you agree that your work:

* Will be released under the GPLv3 for public use, **and**
* May be included in commercial versions licensed by néosResearch.

For details on commercial terms, see [LICENSE.txt](./LICENSE.txt).

---

```

---

### ✅ Summary

This file:
- Clearly binds all contributors to the **dual-license model**,  
- Protects néosResearch’s ability to offer **commercial licenses**, and  
- Keeps the open-source community fully informed and compliant with GPLv3.

Would you like me to also create a **`CODE_OF_CONDUCT.md`** that complements this, using a professional tone (based on the Contributor Covenant v2.1) and fits néosResearch’s brand voice? It’s recommended for public GitHub repositories.
```
