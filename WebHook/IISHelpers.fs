namespace  mahamudra.it.iis 
open System
    module IISHelpers =
        /// Port specified by IIS HttpPlatformHandler
        let httpPlatformPort =
            match Environment.GetEnvironmentVariable("HTTP_PLATFORM_PORT") with
            | null -> None
            | value ->
                match Int32.TryParse(value) with
                | true, value -> Some value
                | false, _ -> None

