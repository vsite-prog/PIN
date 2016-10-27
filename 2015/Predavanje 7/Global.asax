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
        // Code that runs when an unhandled error occurs
        string msg = Server.GetLastError().InnerException.Message;

        //Forget error
        Server.ClearError();
        // Response with error page
        StringBuilder sb = new StringBuilder();
        sb.Append("<html><head><title>Greška</title></head>");
        sb.Append("<body> <h2> Velika greška </h2><hr> <p> Tekst gerške je; ");
        sb.Append(msg);
        sb.Append("</p></body></html>");
        Response.Write(sb.ToString()); //send error page
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
