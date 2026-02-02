# Project Structure Handbook

This document defines the **canonical project structure**, architectural boundaries, and system guarantees for the Inventory Management System. The system is designed to be **offline-first**, **deterministic**, **portable across machines**, and **optionally cloud-enabled** without ever requiring an internet connection for core functionality.

---

## Core Design Principles

1. **Offline-First by Default**  
   The application must function fully without an internet connection. Internet access is optional and never required for core operation.

2. **Deterministic & Reproducible State**  
   Application state must be reconstructible and verifiable from stored artifacts. No hidden or implicit state is allowed.

3. **Portable by Design**  
   Users must be able to migrate or restore their system state using exported files alone.

4. **Bundled Dependencies**  
   All dependencies are bundled with the application. No global installs, runtime downloads, or external tooling are required.

5. **Optional Cloud, Explicitly Enabled**  
   Cloud functionality is opt-in, user-controlled, and strictly supplemental.

---

## Technology Stack

- **Language:** C#
- **Frontend:** Avalonia UI (XAML)
- **Architecture:** MVVM
- **Local Database:** SQLite
- **Logging Model:** Append-only, commit-style change records
- **Cloud:** AWS S3
- **Machine Learning Agents:** Local, read-only inference

---

### Restore Scenarios

#### Database Only
- Treated as a snapshot
- Change history begins anew

#### Change Records Only
- Empty database initialized
- All records replayed in order

#### Database + Change Records (Preferred)
1. Database snapshot is loaded
2. Change records are replayed iteratively
3. Consistency is verified at each step
4. Any mismatch halts installation with an explicit error

No silent correction is permitted.

