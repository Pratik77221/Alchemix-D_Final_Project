# Alchemix'D - VR Audio Alchemy Experience

![Unity Version](https://img.shields.io/badge/Unity-2022.3.51f1-blue)
![VR Platform](https://img.shields.io/badge/VR-Oculus%20%7C%20OpenXR-green)
![Status](https://img.shields.io/badge/Status-Active-success)

## 🎵 Overview

**Alchemix'D** is an immersive VR audio experience that transforms players into sonic alchemists. Step into a mystical virtual reality environment where you explore, collect unique sound ingredients, and craft your own musical compositions by mixing them in a magical cauldron. This project combines interactive audio design, VR mechanics, and creative gameplay to deliver a unique musical crafting experience.

## ✨ Key Features

### 🎮 Immersive VR Gameplay
- **Full VR Support**: Built with Unity XR Interaction Toolkit
- **Hand Tracking & Controllers**: Natural hand animations and controller input
- **Interactive Environment**: Explore a richly detailed VR world filled with sound ingredients

### 🎼 Audio Alchemy System
- **7 Unique Sound Layers**:
  - Bass
  - Kick
  - Percussion
  - Synth 1
  - Synth 2
  - Vocal Chops
  - Keys
- **Dynamic Audio Mixing**: Real-time audio layering as you add ingredients to the cauldron
- **Spatial Audio**: Immersive 3D audio positioning and occlusion effects
- **Interactive Pouring Mechanic**: Pour sound ingredients into the cauldron to activate audio layers

### 🎨 Visual Effects
- **Particle Effects**: Dynamic fire effects triggered by specific sound combinations
- **Smooth Transitions**: Fade-in/fade-out animations for immersive scene transitions
- **Environmental Occlusion**: Audio dynamically responds to environmental obstacles

### 🎁 Easter Eggs
- Hidden surprise content (No spoilers - discover it yourself!)
- Special rewards for completing all audio combinations

## 🛠️ Technical Specifications

### Built With
- **Unity Engine**: 2022.3.51f1
- **Universal Render Pipeline (URP)**: 14.0.11
- **XR Interaction Toolkit**: 2.6.3
- **XR Management**: 4.5.0
- **TextMeshPro**: 3.0.7

### VR Platform Support
- **Oculus/Meta Quest**: Oculus XR Plugin 4.3.0
- **OpenXR Compatible Headsets**: OpenXR Plugin 1.13.0

### Development Tools
- Visual Studio / VS Code integration
- Unity Collab for version control
- Timeline for animations and cutscenes

## 📋 Requirements

### Hardware Requirements
- **VR Headset**: Meta Quest 2/3/Pro, or any OpenXR-compatible VR headset
- **Controllers**: VR hand controllers (or hand tracking on supported devices)
- **PC Specifications** (for development):
  - Windows 10/11 or macOS
  - 8GB RAM minimum (16GB recommended)
  - DirectX 11/12 compatible graphics card
  - 2GB available storage space

### Software Requirements
- Unity Hub (latest version)
- Unity Editor 2022.3.51f1 LTS
- Platform-specific VR software (Oculus App for Meta Quest, SteamVR for OpenXR)

## 🚀 Installation & Setup

### For Developers

1. **Clone the Repository**
   ```bash
   git clone https://github.com/Pratik77221/Alchemix-D_Final_Project.git
   cd Alchemix-D_Final_Project
   ```

2. **Open in Unity**
   - Open Unity Hub
   - Click "Add" and select the project folder
   - Unity will automatically import all required packages

3. **Configure VR Settings**
   - Navigate to `Edit > Project Settings > XR Plug-in Management`
   - Enable your target VR platform (Oculus or OpenXR)
   - Configure input actions in `Assets/XRI/Settings`

4. **Build and Run**
   - Open the main scene: `Assets/Scenes/Main.unity`
   - Connect your VR headset
   - Press Play in Unity Editor or build for your target platform
   - File > Build Settings > Select platform > Build

### For Players

1. Download the latest build from the Releases section
2. Install on your VR device following platform-specific instructions
3. Launch the application from your VR library
4. Put on your headset and enjoy the experience!

## 🎮 How to Play

### Getting Started
1. **Launch the Experience**: Put on your VR headset and start the application
2. **Explore the Environment**: Look around and familiarize yourself with the mystical alchemy lab
3. **Find Sound Ingredients**: Collectible bottles and objects contain unique audio loops

### Crafting Your Music
1. **Grab Ingredients**: Use your VR controllers to pick up sound ingredient bottles
2. **Pour into Cauldron**: Tilt and pour each ingredient into the central cauldron
3. **Watch the Magic**: Each ingredient adds a new layer to your musical composition
4. **Experiment**: Try different combinations and orders to create unique soundscapes

### Controls
- **Grip Button**: Grab and hold objects
- **Trigger Button**: Pinch/select interactions
- **Menu Button**: Open the in-game menu (if available)
- **Joystick/Touchpad**: Navigate menus

### Tips
- Collect all 7 sound layers for the complete experience
- Pay attention to visual cues (fire effects) when certain ingredients are added
- Explore thoroughly - there are hidden surprises waiting to be discovered!

## 📁 Project Structure

```
Alchemix-D_Final_Project/
├── Assets/
│   ├── Audio/                      # Audio files and loops
│   │   ├── Occluded Loops/        # Spatially occluded audio versions
│   │   └── Useless/               # Legacy audio files
│   ├── Animations/                # Animation clips and controllers
│   ├── Materials/                 # Shaders and materials
│   ├── Prefabs/                   # Reusable game objects
│   │   └── colliderPrefab*.prefab # Sound ingredient prefabs
│   ├── Scenes/                    # Unity scenes
│   │   ├── Main.unity            # Main gameplay scene
│   │   └── MainTanish.unity      # Alternative scene
│   ├── Scripts/                   # C# gameplay scripts
│   │   ├── AudioManager.cs       # Audio system controller
│   │   ├── AudioTriggerOnPour.cs # Cauldron audio activation
│   │   ├── BeatLabScript.cs      # Beat detection and triggering
│   │   ├── OnCollision.cs        # Collision-based audio triggers
│   │   ├── GameStartMechanics.cs # Game initialization
│   │   ├── HandAnimationOnInput.cs # VR hand animations
│   │   ├── MenuController.cs     # UI menu system
│   │   └── RickRolled.cs         # Easter egg controller
│   ├── UI/                        # User interface elements
│   ├── XR/                        # XR settings and configurations
│   └── XRI/                       # XR Interaction Toolkit assets
├── Packages/                      # Unity package dependencies
├── ProjectSettings/               # Unity project configuration
└── README.md                      # This file
```

## 🎯 Core Systems

### Audio Management System
The `AudioManager.cs` implements a singleton pattern for centralized audio control:
- Manages multiple audio sources
- Controls volume, pitch, and looping
- Provides Play/Stop methods for easy audio triggering

### Cauldron Interaction System
The `AudioTriggerOnPour.cs` handles the core gameplay mechanic:
- Detects when sound ingredients enter the cauldron
- Activates corresponding audio layers
- Triggers visual effects (fire particles)
- Tracks completion state for all ingredients

### VR Interaction
- Hand presence with animated controllers
- Grab and pour mechanics using XR Interaction Toolkit
- Physics-based object interactions
- Menu system with VR controller input

## 🤝 Contributing

Contributions are welcome! If you'd like to improve Alchemix'D:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 Credits

### Development Team
- **Audio System**: Based on Brackeys' Audio Manager tutorial
- **VR Framework**: Unity XR Interaction Toolkit
- **Project Lead**: Pratik77221

### Third-Party Assets
- Unity XR Interaction Toolkit
- TextMesh Pro
- Universal Render Pipeline
- Various font assets (see Assets/Fonts for individual licenses)

## 📄 License

This project contains various assets with different licenses:
- **Code**: Project-specific code available under repository terms
- **Fonts**: See individual font license files in `Assets/Fonts/`
- **Unity Packages**: Licensed under Unity's terms of use

## 🐛 Known Issues

- Some legacy audio files in the "Useless" folder are not used in the final build
- Build artifacts in `Alchemix'D_BurstDebugInformation_DoNotShip` should not be shipped

## 🔮 Future Enhancements

- Additional sound ingredient types
- Multiplayer collaborative music creation
- Recording and playback of created compositions
- More environmental themes and settings
- Advanced visual effects synchronized with music
- Gesture-based controls for hand tracking

## 📧 Contact & Support

- **GitHub Issues**: Report bugs or request features
- **Repository**: [Alchemix-D_Final_Project](https://github.com/Pratik77221/Alchemix-D_Final_Project)

## 🎮 Gameplay Video

*(Coming Soon - Add gameplay footage here)*

---

**Made with ❤️ and 🎵 in VR**

*Transform sound into magic. Become a Sonic Alchemist.*
