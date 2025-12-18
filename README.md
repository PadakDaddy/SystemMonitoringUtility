# System Monitoring Utility

A simple Windows desktop application that shows real-time information about your computer. Built with C# and Win32 API.

## What It Does

This program shows:
- **CPU Usage** - How much your processor is working
- **Memory Usage** - How much RAM your computer is using
- **Disk Usage** - How much hard drive space you have
- **Running Processes** - List of all programs running now
- **System Information** - Your computer details (OS, RAM, processor)

## Why This Project?

This project uses what we learned in class:
- Windows forms and UI design
- Getting system data from Windows
- Running tasks in the background (threads)
- Managing data in lists and trees
- Design patterns for clean code

## What You Need

- Windows 7 or newer
- .NET Framework 4.7.2 or newer
- Visual Studio 2019 or newer

## How To Use

1. Open the program
2. Look at the real-time numbers on the screen
3. The data updates every second
4. Click on a process name to see more information
5. Click "Refresh" button to update now

## Features

### Main Screen
- Shows CPU, memory, and disk use with live updates
- Simple and easy to read
- Different colors show different levels (green = good, red = bad)

### Process List
- See all programs running now
- Shows how much memory each program uses
- Shows which program uses the most CPU
- Right-click menu to stop programs

### System Info
- Your Windows version
- Total RAM in your computer
- CPU information
- Hard drive size

## Files in This Project

```
SystemMonitor/
├── MainWindow.xaml           - Main screen design
├── MainWindow.xaml.cs        - Main screen code
├── SystemInfo.cs             - Get system data
├── ProcessManager.cs         - Manage running programs
├── UIHelper.cs               - Help with colors and display
└── App.xaml                  - Application setup
```

## How It Works

1. **Get Data** - Program asks Windows for CPU, memory, and disk information
2. **Update Screen** - Show new numbers on screen every 1 second
3. **Run in Background** - Use separate threads so program doesn't freeze
4. **Show Results** - Display in simple tables and charts

## Possible Problems and Answers

**Q: The program shows 0% CPU**
- This is normal. CPU usage changes very fast.

**Q: Some processes don't show memory use**
- This happens with some Windows system programs. It's okay.

**Q: The program uses a lot of memory**
- Close other programs to free up memory first.

## What I Learned Making This

- How to use Win32 API in C#
- How threads work in Windows
- How to get system information
- How to make a user interface (UI)
- How to handle errors
- How to work with data structures like lists

## Future Ideas

<<<<<<< HEAD
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
=======
- Add history charts (show CPU over time)
- Add alerts when something uses too much
- Add ability to save reports to file
- Add network information
- Add temperature information (if available)

## License

This project is for school learning. You can use it and change it freely.

## Questions or Problems?

If something doesn't work:
1. Check that you have .NET Framework 4.7.2 or newer
2. Try restarting the program
3. Check Windows is fully updated
4. Look at error messages carefully

---

**Author**: Student Project
**Date**: December 2025
**School Subject**: Windows Programming Fundamentals
>>>>>>> 15fc64a (changed)
