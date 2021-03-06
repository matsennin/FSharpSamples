namespace FsharpWebApplication
#nowarn "20"
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting

module Program =
    let createHostBuilder args =
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(fun webBuilder -> 
                webBuilder.UseStartup<Startup>() |> ignore
            )
    
    [<EntryPoint>]
    let main args =
        createHostBuilder(args).Build().Run()

        0
        
// http://localhost:5000