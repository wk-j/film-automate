﻿
namespace TourismWeb.Automate

open TourismWeb.Automate.TourismWebSpec
open System

module Starter = 

    [<EntryPoint>]
    let main args =
        TourismWeb.Automate.TourismWebSpec.letsItGo()
        Console.ReadLine() |> ignore
        0