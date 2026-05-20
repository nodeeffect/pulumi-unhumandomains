open System
open System.Threading

open Pulumi.Experimental.Provider

open Pulumi.UnhumanDomains

[<EntryPoint>]
let main args =
    Provider.Serve(args, UnhumanDomainsProvider.Version, (fun _host -> new UnhumanDomainsProvider()), CancellationToken.None)
    |> Async.AwaitTask
    |> Async.RunSynchronously
    0
