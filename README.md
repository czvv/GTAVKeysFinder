# GTAVKeysFinder 🔑
A simple tool to pull AES keys, NG keys, and LUTs out of a GTA V memory dump.

I built this because the original RageLib logic was hitting some walls with newer game versions. I've integrated some logic from CodeWalker to make the scanning more reliable and added null-checks so the app doesn't just crash if it misses a single table.

## 🚀 Features
* **Advanced Scanning:** Uses refined byte-pattern matching to locate keys even in newer game versions.
* **Complete Extraction:** Exports all necessary files for RPF decryption and data analysis:
    * `gtav_aes_key.dat`
    * `gtav_ng_key.dat`
    * `gtav_ng_decrypt_tables.dat`
    * `gtav_ng_encrypt_tables.dat`
    * `gtav_ng_encrypt_luts.dat`
    * `gtav_hash_lut.dat`

## 🛠 Prerequisites
* [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
* A valid memory dump of the GTA V process (e.g., created via Scylla or Task Manager during game runtime).

## 💻 Usage

1. Open a terminal (PowerShell or Command Prompt).
2. Navigate to the directory containing the compiled `GTAVKeysFinder.exe`.
3. Run the following command:

```powershell
./GTAVKeysFinder.exe -executableFile "C:\Path\To\Your\GTA5_dump.exe" -keyPath "C:\Path\To\OutputFolder"
```

## Arguments:
**-executableFile**: The full path to the dumped GTA5 executable/memory file.

**-keyPath**: The directory where the extracted .dat files will be saved.

## 🔄 Updates & Community
* **Maintenance:** I'll keep an eye on this. If a game update breaks the signatures, I’ll try to push a fix.

* **Help out:** If you find a bug or have a better way to find these patterns, please open an issue

## 🤝 Credits
**[Neodymium](https://github.com/Neodymium146/gta-toolkit)** & **[carmineos](https://github.com/carmineos/rage-toolkit)**: Original authors of RageLib.

**[dexyfex](https://github.com/dexyfex/CodeWalker)**: For the improved table-finding logic and research.

## ⚠️ Disclaimer
**This tool is intended for educational and research purposes only. Use it in accordance with your local laws and the game's EULA.**