# System Monitoring Utility

A simple Windows program that shows you what your computer is doing right now.

## What is this?

This program helps you see:
- **CPU Usage** - How busy your processor is (in percent %)
- **Memory Usage** - How much of your RAM is being used (in GB)
- **Disk Space** - How full your hard drives are
- **Running Programs** - What programs are running now
- **Process Management** - Stop programs if needed

Think of it like a health check for your computer!

## Why do you need this?

When your computer is slow, you can use this tool to find out:
- ❌ Which program is using too much memory?
- ❌ Which program is using the CPU?
- ❌ Is my hard drive almost full?

Then you can close the problem programs or clean up space.

## What technology does it use?

- **Windows API** - Low-level Windows commands
- **Threads** - Run multiple things at the same time
- **IPC** (Inter-Process Communication) - Talk between different programs
- **Data Structures** - Store and organize information
- **Design Patterns** - Good way to organize code

## Main Features

1. **Real-time Monitoring** - See information update every second
2. **Process List** - See all running programs with their resource usage
3. **Kill Process** - Stop programs that you don't need
4. **Resource Charts** - See pictures of CPU and Memory over time
5. **Alerts** - Get warning if something uses too much

## How to use it

1. Start the program
2. Look at the main screen
3. Check CPU, Memory, and Disk information
4. Look at the process list
5. Click on a process to see more details
6. Click "End Process" to stop it (be careful!)

## System Requirements

- Windows 10 or newer
- .NET Framework 4.7 or higher
- 4 GB RAM (or more)
- Administrator access (for stopping programs)

## Future Plans

- Export data to CSV file
- Save history of resource usage
- Network monitoring
- Windows Service monitoring

## Technical Notes for Developers

### Architecture

```
User Interface (UI)
        ↓
Logic Layer (Business Logic)
        ↓
Data Collection (Win32 API)
        ↓
System Information
```

### Main Components

- **MonitorWindow** - The display screen
- **SystemMonitor** - Gets system information
- **ProcessManager** - Works with running programs
- **DataCollector** - Saves information over time

### Key Technologies Used

| Technology | What it does |
|-----------|------------|
| Win32 API | Talk to Windows |
| C# / C++ | Programming languages |
| Threads | Update information without freezing |
| Windows Objects | Work with processes and memory |
| Design Patterns | Keep code organized |

## File Structure

```
SystemMonitor/
├── README.md (this file)
├── src/
│   ├── MainWindow.cpp
│   ├── MonitorCore.cpp
│   ├── ProcessManager.cpp
│   └── DataCollector.cpp
├── include/
│   ├── MonitorCore.h
│   └── ProcessManager.h
├── resources/
│   └── styles.xaml
└── docs/
    └── Architecture.md
```

## Building and Running

### Prerequisites
- Visual Studio 2019 or newer
- Windows SDK
- C++ development tools

### Build Steps
1. Open `SystemMonitor.sln`
2. Click Build → Build Solution
3. Press F5 to run

### Run Steps
1. Find `SystemMonitor.exe` in output folder
2. Double-click to start
3. Right-click icon in system tray for options

## Important Notes

⚠️ **Be careful when stopping programs!**
- Do NOT stop system programs (those with "system" in name)
- Do NOT stop Windows programs (those with "Windows" in name)
- Always save your work before stopping programs

## Troubleshooting

**Program runs slowly:**
- This is normal when many programs are running
- Try closing some other programs
- Check your disk space

**Can't stop a process:**
- You may need Administrator rights
- Right-click the program and pick "Run as Administrator"

**Shows wrong information:**
- Try restarting the program
- Check that no other system programs are broken

## Learning Goals

This project teaches:
- ✅ Win32 API usage
- ✅ Multithreading in Windows
- ✅ Process and memory management
- ✅ Real-time data collection
- ✅ User interface design
- ✅ Design patterns in practice
