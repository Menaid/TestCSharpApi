// Global settings
Globals = Obj(new
{
    debugOn = true,
    detailedAclDebug = false,
    aclOn = true,
    isSpa = true,
    port = 3001,
    serverName = "Meno's Minimal API Server",
    frontendPath = FilePath("..", "Frontend"),
    sessionLifeTimeHours = 2
});

Server.Start();