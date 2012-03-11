#r @"..\..\src\FSharpx.TypeProviders\bin\Debug\FSharpx.Typeproviders.dll"
#r @"Microsoft.Office.Interop.Excel.dll"
#r @"office.dll"

open Microsoft.Office.Interop

let filename  = @"BookTest.xls"


//get-process | where-object { $_.name -eq "excel" } | sort-object -property "Starttime" -descending | select-object -skip 1 | foreach { taskkill /pid $_.id }
if false then
   let file = FSharpx.TypeProviders.ExcelProvider.ExcelFileInternal(filename, "Sheet1")
   printf "%A" file.Data
elif false then
   let file = new FSharpx.TypeProviders.ExcelProvider.ExcelFile<"BookTest.xls", "Sheet1", true>()
   printf "\n****Using typeprovider***\n"
   printf "%A" file.Data
   let firstrow = file.Data |> Seq.head
   printfn " Field        :   Value in XL         :  Value throught TP"
   printfn " SEC          :   ASI                 :  %A  " firstrow.SEC          
   printfn " UNDERLYING   :   JPY-NIKKEI 225      :  %A  " firstrow.UNDERLYING      
   printfn " STRATEGY     :   DIV_SWAP            :  %A  " firstrow.STRATEGY     
   printfn " STYLE        :   A                   :  %A  " firstrow.STYLE           
   printfn " MATURITIES   :   01-DEC-89           :  %A  " firstrow.MATURITIES   
   printfn " STRIKE 1     :   0,00                :  %A  " firstrow.``STRIKE 1`` 
   printfn " STRIKE 2     :                       :  %A  " firstrow.``STRIKE 2`` 
   printfn " STRIKE 3     :                       :  %A  " firstrow.``STRIKE 3`` 
   printfn " RATIOS       :   -1                  :  %A  " firstrow.RATIOS          
   printfn " REF          :   8.460,76            :  %A  " firstrow.REF
   printfn " BID          :   -1,000              :  %A  " firstrow.BID         
   printfn " FAIR         :   0,000               :  %A  " firstrow.FAIR         
   printfn " OFFER        :   195,000             :  %A  " firstrow.OFFER         
   printfn " INTEREST     :   --                  :  %A  " firstrow.INTEREST         
   printfn " C/P          :   --                  :  %A  " firstrow.``C/P``         
   printfn " SPR(B)       :                       :  %A  " firstrow.``SPR(B)``         
   printfn " VOL          :                       :  %A  " firstrow.VOL         
   printfn " SPR(O)       :                       :  %A  " firstrow.``SPR(O)``         
   printfn " LAST UPDATE  :   21/12/11 01:18      :  %A  " firstrow.``LAST UPDATE``         
   printfn " BROKER       :   TFS Derivatives HK  :  %A  " firstrow.BROKER         
elif true then
   let file = new FSharpx.TypeProviders.ExcelProvider.ExcelFile<"BookTest.xls", "ThisIsaRange", true>()
   printf "\n****Using typeprovide range***\n"
   printf "%A" file.Data
   let firstrow = file.Data |> Seq.head
   printfn " Field        :   Value in XL         :  Value throught TP"
   printfn " SEC          :   ASI                 :  %A  " firstrow.SEC          
   printfn " UNDERLYING   :   JPY-NIKKEI 225      :  %A  " firstrow.UNDERLYING      
   printfn " STRATEGY     :   DIV_SWAP            :  %A  " firstrow.STRATEGY     
   printfn " STYLE        :   A                   :  %A  " firstrow.STYLE           
   printfn " MATURITIES   :   01-DEC-89           :  %A  " firstrow.MATURITIES   
   printfn " STRIKE 1     :   0,00                :  %A  " firstrow.``STRIKE 1`` 
   printfn " STRIKE 2     :                       :  %A  " firstrow.``STRIKE 2`` 
   printfn " STRIKE 3     :                       :  %A  " firstrow.``STRIKE 3`` 
   printfn " RATIOS       :   -1                  :  %A  " firstrow.RATIOS          
   printfn " REF          :   8.460,76            :  %A  " firstrow.REF
   printfn " BID          :   -1,000              :  %A  " firstrow.BID         
   printfn " FAIR         :   0,000               :  %A  " firstrow.FAIR         
   printfn " OFFER        :   195,000             :  %A  " firstrow.OFFER         
   printfn " INTEREST     :   --                  :  %A  " firstrow.INTEREST         
   printfn " C/P          :   --                  :  %A  " firstrow.``C/P``         
   printfn " SPR(B)       :                       :  %A  " firstrow.``SPR(B)``         
   printfn " VOL          :                       :  %A  " firstrow.VOL         
   printfn " SPR(O)       :                       :  %A  " firstrow.``SPR(O)``         
   printfn " LAST UPDATE  :   21/12/11 01:18      :  %A  " firstrow.``LAST UPDATE``         
   printfn " BROKER       :   TFS Derivatives HK  :  %A  " firstrow.BROKER         
 elif false then  //This refers to a named Range
   let file = new FSharpx.TypeProviders.ExcelProvider.ExcelFile<"BookTestBrokernet.xls", "Brokernet", true>()
   printf "\n****Using typeprovider with custom sheet name***\n"
   printf "%A" file.Data
else 
   let file = new FSharpx.TypeProviders.ExcelProvider.ExcelFile<"BookTestBig.xls", "Sheet1", true>()
   printf "\n****Using typeprovider with BIG file - actually not so much but it is slow nonetheless... - ***\n"
   printf "%A" file.Data
