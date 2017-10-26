//=================================================================================
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
using System.Text;
using Newtonsoft.Json;

namespace MYC
{
    public class BittrexBalance
    {
        [JsonProperty]
        public String Currency { get; private set; }

        [JsonProperty]
        public Double Balance { get; private set; }

        [JsonProperty]
        public Double Available { get; private set; }

        [JsonProperty]
        public Double Pending { get; private set; }

        [JsonProperty]
        public String Address { get; private set; }

        [JsonProperty]
        public Boolean Requested { get; private set; }

        [JsonProperty]
        public String Uuid { get; private set; }

        public override String ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.AppendFormat( "{0,-17} {1,-40}\n", "Currency:", Currency );
            SB.AppendFormat( "{0,-17} {1,-40:0.00000000}\n", "Balance:", Balance );
            SB.AppendFormat( "{0,-17} {1,-40:0.00000000}\n", "Available:", Available );
            SB.AppendFormat( "{0,-17} {1,-40:0.00000000}\n", "Pending:", Pending );
            SB.AppendFormat( "{0,-17} {1,-40}\n", "Address:", Address );
            SB.AppendFormat( "{0,-17} {1,-40}\n", "Requested:", Requested );
            SB.AppendFormat( "{0,-17} {1,-40}\n", "Uuid:", Uuid );
            
            return SB.ToString();
        }
    }
}