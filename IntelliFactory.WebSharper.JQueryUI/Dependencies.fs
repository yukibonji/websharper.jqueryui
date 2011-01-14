﻿// $begin{copyright}
//
// This file is confidential and proprietary.
//
// Copyright (c) IntelliFactory, 2004-2009.
//
// All rights reserved.  Reproduction or use in whole or in part is
// prohibited without the written consent of the copyright holder.
//-----------------------------------------------------------------
// $end{copyright}

module IntelliFactory.WebSharper.JQueryUI.Dependencies

module R = IntelliFactory.WebSharper.Resources

[<Sealed>]
type JQueryUI() =
    inherit R.BaseResource(
        "http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1",
        "/jquery-ui.min.js",
        "/themes/base/jquery-ui.css")

