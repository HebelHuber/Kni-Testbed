# kni Engine game template

- Use the [installer](https://github.com/kniEngine/kni/releases/download/v4.0.9001/KniSdkSetup4.0.9001.exe) to install KniSdk 4.0.9001
- Clone this repo

## [Sampe](https://hebelhuber.github.io/Kni-Testbed/browser-publish-release/wwwroot/)

## ToDo

- show progress for wasm loading [link](https://chat.deepseek.com/a/chat/s/10e63fc3-86d8-4a81-b3ff-d8274b4c20b7)
- direct file loading instead of using the content pipeline [link](https://chat.deepseek.com/a/chat/s/ab15291a-3d91-4d5c-bc32-6f5e9ec0be09)
  - needs work on wasm
  - endgoal is to avoid using kni installer since it installs only content pipeline tools and vs templates
  - meshes should be described in code using generators
  - runtime loading from files is for development. eventually all assets should be embedded (as it will be mainly textures, from file should also be fine)
- GUI
  - imgui
  - iguina [link](https://github.com/RonenNess/Iguina?tab=readme-ov-file#introduction)
  - apos [link](https://github.com/Apostolique/Apos.Gui)
  - with a functioning GUI, add an `[Inspector]` attribute that adds marked fields to a debug inspector ingame. might need reflection, check for wasm. or maybe write a code generator that generates the inspector code
- compiling shaders at runtime from file
  - claude: Loading GLSL Shaders at Runtime in MonoGame
- deferred rendering with decals [link](https://chat.deepseek.com/a/chat/s/dcb2e4c3-3286-4cf1-a2f3-841c633f2dec)
  - [Deferred Engine playground](https://community.monogame.net/t/deferred-engine-playground-download/8180)
  - [DeferredEngine](https://github.com/Kosmonaut3d/DeferredEngine)
  - [Decal technique from Star Citizen](https://polycount.com/discussion/155894/decal-technique-from-star-citizen)
  - POM
- Fitting pixel art buffer to [screen](https://community.monogame.net/t/fitting-pixel-art-game-to-screen/17043)
- [Realtime edge damage masking](https://www.artstation.com/blogs/jjg/B2Dd/real-time-edge-damage-masking)
- deferred rendering with shadows
- add a physics engine
  - 2d https://github.com/nkast/Aether.Physics2D
  - 3d https://digitalrune.github.io/DigitalRune-Documentation/html/79a8677d-9460-4118-b27b-cef353dfbd92.htm
