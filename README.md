# Wellness-app-BE-DB
Welness app backend + database

#Add JWT secret key:

for 256-bit secure key, use 32 bit secret key = 32 characters long
(keygen.io works good enough, but best to implement own)

#Create user database

Need to specify which context to use as project has 2 databases
nuget package manager -> 

"add-migration Initial -Context ApplicationDbContext"

"update datase -Context ApplicationDbContext"
