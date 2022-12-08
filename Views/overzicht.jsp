<%-- 
    Document   : overzicht
    Created on : 13-Oct-2022, 09:17:28
    Author     : felix
--%>
<%@ taglib uri = "http://java.sun.com/jsp/jstl/functions" prefix = "fn" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ page import=" Data.reservatiedata, java.util.List" %>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>overzicht</title>
          <%@ include file="head.jspf" %>
    </head>
    <body>
        <%@ include file="/fragment.jspf" %>
        <h3> user ${sessionScope.klantid} 's reservations</h3>
        <h3>totaal voor laatste res ${hp}</h3>
        <div class="container">
            <c:forEach items="${sessionScope.reservaties}" var="ind" >
                <div class="fx-row"> 

                    <div class="fx-col-5" ><p class="w-20">start locatie:${ind.sloc} </p></div>
                    <div class="fx-col-5" ><p class="w-20">eind locatie:${ind.eloc}</p></div>
                    <div class="fx-col-5" ><p class="w-20">voertuig:${ind.atype}</p></div>

                    <div class="fx-col-5" ><p class="w-20">begin:${ind.sdat}</p></div>
                    <div class="fx-col-5" ><p class="w-20">duur:${ind.dlen}</p></div>


                   
                
                </div>
            </c:forEach>
        </div>
        <a href="<c:url value='/reserveer.jsp' />"> <h3>Nieuwe reservatie</h3></a> 
         <%@ include file="/footer.jspf" %>
    </body>
</html>
