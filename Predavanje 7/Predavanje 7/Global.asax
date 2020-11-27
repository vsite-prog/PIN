<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup

    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Zajednički hvatač neuhvaćenih iznimka
        string tekstGreske = Server
            .GetLastError()
            .InnerException
            .Message;
        // Vratili bi status 500 i nekakav template
        Response.Write("Greška: <b> " + tekstGreske + "</b>");
        Server.ClearError(); // Ne treba dalje obrađivati

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

</script>
