

Notes:
    make two Solutions, DI and no DI. it was confusing 
    Should it follow clean arch? that could be too much cog load
Steps:
Show ERD/UML for DomainNoDI, point out the direction of dependencies/arrows
Have them new-up a House can call start and end day. Show how its easy to "new up" a `House` with this bad way
New Problem: `new is glue`
    Mention we can't change this code at runtime.
    Two biggest use cases
        1. Runtime, pick implementation
        2. Testing
    "You might say ok then we need to pass in the instance." 
    Show how we can change to pass in the instance instead (no interface)
    New Problem: What if I want to change how one of these methods work, use interface (or abstract class).
        Show how to extract interface from class with vs 2022, update class and dependant class to use interface
        Show updated UML, point out the reverse arrows
        Add new implementation of class that has a different calculation for the return value and show with an if statement we can new-up the one we want and pass it in
        Show updated UML with the two implementations.
    "Where this technique is used the most is in unit testing"
    Show how by trying to test `House` by trying to switch out one of the dependencies    
        need to change at least one of the classes' methods to return a calculated value so it makes sense to want to swap out to a hardcoded value with a Unit test
        implement the class again but hardcode the response for testing
        "this way we remove all `confounding variables` and only test the code we really want to test. That way if there is an error we know exactly where the problem is. There is a time for integration testing too, but this is unit testing"
    This is called IOC, inversion of control, or Dependance Inversion or Dependency Injection
    "Great, I'm convinced lets DI all the classes"
    Switch to the new DI project and show the new UML
    Then have them new up a House
    New Problem: I don't want to write all this code every time!
        point out that now we have the flexibility to change the code every time and that's cool but still a lot to write.
    Fix: IOC container for the win!
    Demo:
        show how to add House class as class to the container as transient.
        then build the container
        then ask the container for a House, show requiredService vs getService
        Then call startDay and endDay on house.
        Run
        show the error the container doesn't know how to make the other interfaces
        Explain that it's only run time check
        add all the other interfaces and classes to the container as transient
        Then run again. Ya! it works
        Show you can get a different instance just by asking for one
    Demo:
        show how you can add an if statement to decide what to implementation to add to the container.
    Demo:
        other things you might want to do with a container
            shows what happens if more than one class that implements an interface is added
                show how to get them all in a list
            Show singleton, and scoped
                show how to get a scope and demo getting the same instance in the same scope
            Show making an instance and then added that to the container as singleton
    go back to basic DI code and say ok now that you have the basics it's still mostly the same amount of code the magic comes when using this to cross layers in Clean Architecture
    Switch to a basic clean architecture project set up, Have them build this in another demo or now?
    switch the main from newing-up all the things to making a IOC container and getting an instance and running the code
    Then say thats cool but presentation has to know how all the layers work, not good
    Make an extension method that attaches to the IOC Container class in application and infrastructure. and farm out the pieces to the right parts
    call them from main before you build
    then run and show works
    Then show to make a new class in application it can pull in the infrastructure services really easy by just asking for them in the constructor
    This is the magic!
    
    Teach Configuration in a simular bare bones way, by newing up the class yourself
        teach the settings object with interfaces too
        IOptions



    Then can introduce IHostBuilder
        It does DI, Configuration, Logging and process management for you! "For CLI we don't really need the process management
        
        set that up showing that it's the same just a little different
        take the time to teach logging now using ILogger<class>
            Other logging things 
                scopes?
        can log to file and console - maybe save till serilog
        change some Application classes to use ILogger
        Show how Ilogger is better for multi Thredding
        flush on shutdown Ilogger

    Cool now our CLI can only do one thing
        Build "Actions" that template uses
        "What if we want more verbs and params"
            lib
    
    Show the extra things that the template has
        adding Key Vault
        adding current user service
        adding the database
        the SOA properties on the Options Object
        Serilog

    Now we can teach mediatr
        highlighting the pipeline and vertical slices, functional nature
        Then set up verbs to take mediatr and make requests
            Set up each pipeline behavior
                logging
                validating
                error handling
                Other?
    

    Then can teach ASP.Net (or maybe blazer?) "as just another presentation" 
        Teach the basic parts that ASP.Net needs with a picture
        Then show where in the template those things are



        

    
        
