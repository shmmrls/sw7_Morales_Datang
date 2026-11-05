# Preschool Information Desktop App

![Language](https://img.shields.io/badge/language-C%23-239120?logo=csharp&logoColor=white)
![Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4)
![Type](https://img.shields.io/badge/type-Windows%20Forms-lightgrey)
![Platform](https://img.shields.io/badge/platform-Windows-0078D6)

A multi-page **Windows Forms desktop application** written in C# that presents a preschool's
information the way a website would: a home page, programs and services, an "About Us" section,
testimonials, a locations page, and references, all connected through a navigation menu.

This project focuses on **UI design and multi-form navigation**: building a polished, branded
interface with a consistent layout across ten screens.

---

## Table of Contents

- [Screens](#screens)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
- [Technical Highlights](#technical-highlights)
- [Project Structure](#project-structure)
- [Known Limitations and Roadmap](#known-limitations-and-roadmap)
- [Disclaimer](#disclaimer)
- [Authors](#authors)
- [License](#license)

## Screens

The navigation menu groups the pages like a typical website:

| Menu | Page | Description |
|------|------|-------------|
| **Home** | Home | Landing page with the school's tagline and branding |
| **Services** | Programs | The learning programs offered |
| | Offers | Current offers and promotions |
| | Activities | Activities for the children |
| **About Us** | Get to Know Us | Introduction to the school |
| | Mission | Mission statement |
| | Vision | Vision statement |
| | Testimony | Testimonials |
| **Maps** | Maps | School locations with map previews |
| **References** | References | Reference and source information |

## Features

- **Ten fully designed screens** sharing one consistent branded layout
- **Navigation menu with dropdowns** (Services and About Us) available on every page
- **Clickable logo and "Back to Homepage" button** for quick return to the start
- **Custom artwork and styled menu** with a cohesive color scheme and typography
- **Zero external dependencies**, built only on the .NET Framework

## Tech Stack

| Layer | Technology |
|-------|------------|
| Language | C# |
| UI | Windows Forms (.NET Framework 4.7.2) |
| IDE | Visual Studio |

## Getting Started

### Prerequisites

- Windows with **Visual Studio** (the *.NET desktop development* workload)
- **.NET Framework 4.7.2** developer pack

### Run the project

```bash
git clone https://github.com/shmmrls/preschool-info-desktop-app.git
cd preschool-info-desktop-app
```

1. Open `sw7_Morales_Datang.sln` in Visual Studio.
2. Press **F5** to build and run. The application opens on the Home page.

## Technical Highlights

- **Multi-form navigation:** each page is its own `Form`; menu clicks create and show the target
  form and hide the current one, producing a website-like flow.
- **`MenuStrip` with nested dropdowns:** a hierarchical navigation menu built with
  `ToolStripMenuItem` and wired to event handlers.
- **Designer-driven UI:** layouts built with the Visual Studio designer, using `PictureBox`
  controls and background images for a custom, branded look.
- **Embedded resources:** images are stored in the project's `Resources` and loaded through the
  strongly typed `Properties.Resources` class.
- **Separation of concerns:** UI layout lives in `*.Designer.cs` files while navigation logic
  lives in the matching code-behind files.

## Project Structure

```text
preschool-info-desktop-app/
├── Program.cs                         # Entry point; launches the Home form
├── Home.cs                            # Landing page
├── Programs.cs / Offers.cs / Activites.cs     # Services pages
├── About Us.cs / Mission.cs / Vision.cs / Testimony.cs   # About Us pages
├── Maps.cs                            # Locations page
├── References.cs                      # References page
├── *.Designer.cs                      # Auto-generated UI layout for each form
├── Resources/                         # Images and artwork
├── Properties/                        # Assembly info, resources, settings
├── sw7_Morales_Datang.csproj          # Visual Studio project file
├── sw7_Morales_Datang.sln             # Visual Studio solution file
└── README.md
```

## Known Limitations and Roadmap

This project was built as a school assignment. Planned improvements:

- [ ] **Exit the application cleanly:** closing a page other than the first one currently leaves
      the program running in the background, because hidden forms stay open. Handle `FormClosed`
      (or navigate by closing forms) so the app always exits properly
- [ ] **Reuse form instances** instead of creating a new form on every click, which keeps
      hidden forms accumulating in memory
- [ ] **Remove the duplicated menu code:** the same menu and handlers are repeated in all ten
      forms. A shared base form or a reusable user control would remove the duplication
- [ ] Implement or remove the empty click handlers on the **Services** and **About Us** parent menu items
- [ ] Fix the `Activites` spelling in the class and file name
- [ ] Present page content with real controls (labels, text) instead of mostly image-based layouts,
      making it easier to edit and more accessible
- [ ] Add screenshots to this README

## Disclaimer

This is an educational project. The school name, logo, photographs, and other branding shown in
the application belong to their respective owners and are used here for learning purposes only.

## Authors

- **Trisha Mia Morales**: [@shmmrls](https://github.com/shmmrls)
- **Julia Faye C. Datang**

## License

No license has been specified for this project yet. Add a `LICENSE` file (for example,
[MIT](https://choosealicense.com/licenses/mit/)) if you want others to reuse the code.
