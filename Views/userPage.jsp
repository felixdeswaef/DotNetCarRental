<%-- 
    Document   : userPage
    Created on : 29-sep-2022, 9:37:03
    Author     : r0699163
--%>
<%@ page import="java.util.List, Data.LocationsData" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <%@ include file="head.jspf" %>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>user Page</title>
        
    </head>
    <body>
                    <%@ include file="/fragment.jspf" %>
        <h1 class="text-center">welcome user ${sessionScope.klantid}  </h1>
        <div class="container">
        
        <form method="post" action="<c:url value='/app/res' />">
           
            <div class="fx-row" ><p class="w-20">naam:<input name="NAME" type="text"/></p></div>
            <div class="fx-row" ><p class="w-20">adress:<input name="ADRR" type="text"/></p></div>
            <div class="fx-row" ><p class="w-20">gemeente:<input name="GEMN" type="number"/><input name="GEMT" type="text"/></p></div>

            
            <input name="ORIGIN" type="text" value="USERDATA" hidden="True">
            <div class="fx-row" ><input type="submit"/></div>
        </form>
            
        </div>
            <%@ include file="/footer.jspf" %>
    </body>
</html>
