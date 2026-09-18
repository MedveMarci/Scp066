<h1 align="center">SCP-066 - "Eric's Toy"</h1>

<h2 align="center"> 🧣 Adds an amorphous mass of braided yarn and ribbon monster to the game 🧣</h2>
<p align="center">
  <img src="https://github.com/MedveMarci/SCP-066/blob/main/Photos/Main.png" alt="SCP-066 - `Eric's Toy`">
</p>

# Abilities

## 🔔 **Eric?** and 🔉 **Note** - Play sounds that all players will hear.

<p align="center">
  <img src="https://github.com/MedveMarci/SCP-066/blob/main/Photos/Eric.png" alt="SCP-066 - `Abilities`">
</p>

## 🎺🎻 **Noise** - Plays Beethoven's Symphony No. 2, which kills players near SCP-066

<p align="center">
  <img src="https://github.com/MedveMarci/SCP-066/blob/main/Photos/Noise.png" alt="SCP-066 - `Abilities`">
</p>

# Dependencies

| Dependency                                                                      | Required | Description                     |
|---------------------------------------------------------------------------------|----------|---------------------------------|
| [RoleAPI](https://github.com/MedveMarci/RoleAPI/releases/latest)                | Yes      | Custom role and ability support |

# Installation

1. Download the [latest release](https://github.com/MedveMarci/SCP-999/releases/latest):
   - `Scp066.dll`
   - `Schematics.tar.gz`
2. Place `Scp066.dll` in `LabAPI/plugins/global/`
3. Extract `Schematics.tar.gz` to `LabAPI/configs/ProjectMER/Schematics/`
4. Install the required dependencies listed above
  - If you're using the RueI version of RoleAPI, you need to install Scp066-RueI.dll instead of the normal one.

> The audio files are embedded into `Scp066.dll`.
> Playing them still requires an `.ogg` reader on the server: the `SecretLabNAudio.NVorbis` module.

# Replacing the sounds

The plugin creates `LabAPI/configs/Scp066/Audio/` on startup. Any file placed there replaces the built-in sound with the
same name (`Beethoven.ogg`, `Eric1.ogg`-`Eric3.ogg`, `Notes1.ogg`-`Notes6.ogg`); anything missing from the folder is
played from the DLL. No restart is needed after swapping a file.

# Commands

- Give permission ``ucr.*`` to your role in ``~/LabAPI/configs/permissions.yml``
- Use ``ucr give [id] 66`` to give scp066 to specific player
- If you want to remove, just simply set the player to a different role.

# Credits

- The [main plugin](https://github.com/RisottoMan/SCP-066) created by ``RisottoMan``
- LabAPI support by ``MedveMarci``
- Thanks ``PaЯRoT`` for the creating model and for publishing in KO-FI
- Thanks to everyone who helped test SCP-066

<p align="center">
  <img width="400" src="https://github.com/MedveMarci/SCP-066/blob/main/Photos/Credit.png" alt="Credit">
</p>
