# 🧩 Escape from Maze

A simple console-based maze-solving game written in C#. The program generates a maze and uses a breadth-first search (BFS) algorithm to find the exit. The pathfinding logic was implemented from scratch without third-party libraries.

> 🕹️ This project was originally created over 10 years ago as one of my first steps into software development. I’ve now updated it with better structure, pathfinding, and visualization.

---

## 📸 Preview
![Maze Interface](/Maze/Files/view.jpg)

- 🟥 Red numbers show explored tiles.
- 🟩 Green numbers highlight the correct path from start to exit.

---

## 🛠 Features

- ✅ Maze generation
- ✅ Console-based rendering
- ✅ BFS pathfinding algorithm
- ✅ Real-time step-by-step animation
- ✅ Colored path distinction
- ✅ Clear code structure (MVC-ish pattern)

---

## 🚀 Getting Started

### Requirements

- [.NET Framework](https://dotnet.microsoft.com/en-us/download/dotnet-framework) or Visual Studio (2015+ recommended)

### Run the Project

1. Open the solution file `Maze.sln` in Visual Studio.
2. Set `Maze` as the startup project.
3. Run the application with `Ctrl + F5`.

---

## 🧠 Algorithm

- The maze is represented as a 2D grid.
- The player starts at a defined position.
- A BFS algorithm explores each walkable tile and records the path.
- Once the exit is found, the path is reconstructed and displayed in green.

---

## 🎨 Customize

- You can change maze dimensions in `GameController.cs`.
- Modify colors and characters in `ConsoleBlock.cs`.
- Add delays with `Thread.Sleep()` to visualize search speed.

---

## 🤍 Then vs Now

> This project was born out of curiosity when I was first learning to code. Revisiting it now reminds me how much growth can happen in a decade. From basic console output to real-world systems — this is where it started.

---

## 📜 License

MIT License. Feel free to fork, modify, and use it as a base for your own maze games.

---

## 🙌 Author

**Grigor Temejikyan** – [@TGrigor](https://github.com/TGrigor)

If you enjoy seeing beginner-to-pro transformation projects like this, consider starring ⭐ the repo!

