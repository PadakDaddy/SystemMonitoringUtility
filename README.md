# System Monitoring Utility

A simple Windows desktop application that shows real-time information about your computer.  
Built with C# and the Windows API.

It displays current CPU, memory, and disk usage and updates continuously using background tasks and threads.

---

## 2026-02-22 — ver 1.0

### What It Does

This program shows:

- **CPU Usage** – How much your processor is working in real time
- **Memory Usage** – How much RAM your computer is using
- **Disk Usage** – How much your disks are being used
- **Running Processes** – A live list of all programs and background processes
- **System Information** – Basic details about your system (OS, RAM, processor, etc.)

---

## In Progress (next version)

- Detect **CPU and memory spikes per process**  
  - Track previous CPU/Memory usage by process  
  - Highlight processes whose usage suddenly jumps above a configurable threshold
- More user-friendly UI for monitoring and visual alerts

---

## Future Ideas

- User-friendly and customizable UI (themes, layout options)
- History view or simple logging of high-usage processes
- Export reports for troubleshooting performance issues
