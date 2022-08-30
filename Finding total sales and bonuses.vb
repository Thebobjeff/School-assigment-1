
Module VBModule
    Sub Main()
        Console.clear()
        call cal()
    End Sub
    Sub cal()
         Dim bonus_rate As double
         Dim employe_num() As integer = {1,2,3,4,5,6,8,9,7,10}
         Dim sales(,) as double = {
            {2400,3500,2000},{1500,7000,1000},{600,450,2100},{790,240,500},
            {1000,1000,1000},{6300,7000,8000},{1300,450,700},{2700,5500,6000},
            {4700,4800,4900},{1200,1300,400}}
         Dim sales_mount(9,0) as double = {}
         Dim bonus_mount(9,0) as double = {}
         Dim bonus_total(9,0) as double = {}
         
         Console.Writeline("What is the current bonus rate")
         bonus_rate = console.readline
         
        'adding the sales for month
         for j as integer = 0 to 9
                 sales_mount(j,0) = sales(j,0) + sales(j,1)+ sales(j,2)
                 
          next
          'finding the total bonus and bonus
         for i as integer = 0 to 9
            bonus_total(i,0) = sales_mount(i,0) + (sales_mount(i,0) * (bonus_rate/100))
            bonus_mount(i,0) =  sales_mount(i,0) * (bonus_rate/100)
         next
         
        
         call output(employe_num,sales_mount,bonus_mount, bonus_total,bonus_rate)
         
        
         
    End Sub 
     Sub output(employe_num(,)  ,sales_mount(,)  ,bonus_mount(,) , bonus_total(,),bonus_rate as double)
        Console.clear()
        Console.Writeline("Bonus persent:      %"&bonus_rate)
         Console.Writeline("employe Number:    Total sales:          bonus:          Total Bonus:")
         for i as integer = 0 to 9 
            Console.Writeline(employe_num(i)&"                  "& sales_mount(i,0)&
            "                  "&bonus_mount(i,0)&"             "& bonus_total(i,0))
         next
     End sub
End Module
    







