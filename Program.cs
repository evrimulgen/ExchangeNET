﻿//=================================================================================
//
//  Created by: MrYukonC
//  Created on: 21 OCT 2017
//
//=================================================================================
//
// MIT License
//
// Copyright (c) 2017 MrYukonC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
//
//=================================================================================

using System;
using System.Collections.Generic;
using System.Threading;

namespace MYC
{
    public enum Exchange
    {
        Unknown,
        Bittrex,
        Poloniex
    }

    class Program
    {
        // static Exchange s_Exchange  = Exchange.Unknown;
        // static String   s_APIKey    = String.Empty;
        // static String   s_APISecret = String.Empty;


        //==========================================================
        static void Main( String[] Args )
        {
            // Check the following out for parsing command line args:
            // https://blog.terribledev.io/Parsing-cli-arguments-in-dotnet-core-Console-App/

            BittrexExt B = new BittrexExt( "BITTREX_API_KEY_HERE", "BITTREX_API_SECRET_HERE" );
            
            B.AutoBuy( "BTC-OMG", "BTC", "OMG" );
            //B.AutoSell( "BTC-ZEC", "ZEC", "BTC" );
            //B.WithdrawAll( "ETH", "YOUR_DESTINATION_ADDRESS_HERE" );

            //Poloniex P = new Poloniex( "BITTREX_API_KEY_HERE", "BITTREX_API_SECRET_HERE" );            
            //P.ReturnBalances();
        }
    }
}
