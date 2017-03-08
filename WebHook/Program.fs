// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open Suave
open mahamudra.it.iis

[<EntryPoint>]
let main argv =
    let config = defaultConfig
    let config =
        match IISHelpers.httpPlatformPort with
        | Some port ->
            { config with
                bindings = [  HttpBinding.createSimple HTTP "127.0.0.1" port ] }
        | None -> config

    startWebServer config (Successful.OK "Hello World!")
    0