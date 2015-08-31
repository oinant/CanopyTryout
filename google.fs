namespace PageObjects
module Google =    
    open canopy

    let goToFirstResultFor (search:string) = 
        url "https://www.google.com"
        "#lst-ib" << search
        click "button[name=btnG]" 
        click (first "div.srg a")

