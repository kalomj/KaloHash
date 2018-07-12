# KaloHash
This application reads a disk and calculates a SHA256 hash to validate integrity and authenticity of an ISO after burning to media. It uses CreateFile() from the kernel32.dll library on windows to read the disc volume and the System.Cryptography library to calculate a SHA256 hash.
