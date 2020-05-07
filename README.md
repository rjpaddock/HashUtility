# HashUtility
Simple command line utility for creating a hash of a passed in string or a passed in file.

Parameter 1 = item to hash
Parameter 2  STRING (default) or FILE (optional parameter)

Default is to crete a SHA512 hash of the passed in string
If the 2nd parameter is FILE the application reads the content of the file into a string variabe and hashes that value

Example calls:
.\HashUtility.exe rodman

Returns: 51118f1931d749007f6262fe8c1df8f4894903decd8fd78693f9b8d26fc70298311deabb11f2833652baec3cf87d4b7f444d6379cd34bb284155cd712741d42a

.\HashUtility.exe "D:\Data\clients\DashPoint\WritingProjects\HashUtility\HashUtility\Program.cs" FILE

Returns: ff36b5133b7c99486b62888e5faead2b9e61e3c6e8eacb7032520a39e1985c444a9d9ca0a8787d1b777e846881b73e2a78f6c3165f91a8aa4299c3bc212259a5
