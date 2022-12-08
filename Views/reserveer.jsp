<%-- 
    Document   : reserveer
    Created on : 6-okt-2022, 9:00:27
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
        <title>reserveer</title>
    </head>
    <body>
        <%@ include file="/fragment.jspf" %>
        <h1 class="text-center">welcome user ${sessionScope.klantid}  </h1>
        <div class="container">
        <div class="fx-row"> 
        <form method="post" action="<c:url value='/app/res' />">
            <div class="fx-col-5" ><p class="w-20">start locatie:<select name="SLOC" size="1">
                
                   <c:forEach begin="0" end="${applicationScope.LocationsLength-1}" var="ind" >
                       <option value="${applicationScope.LocationIds[ind]}" >${applicationScope.Locations[ind]}</option>
                   </c:forEach>   
                    </select> </p></div>
            <div class="fx-col-5" ><p class="w-20">eind locatie:<select name="ELOC" size="1">
                   <c:forEach begin="0" end="${applicationScope.LocationsLength-1}" var="ind" >
                     <option  value="${applicationScope.LocationIds[ind]}" >${applicationScope.Locations[ind]}</option>
                   </c:forEach>
                    </select> </p></div>
            <div class="fx-col-5" ><p class="w-20">voertuig:<select name="VEHI" size="1">
               <c:forEach begin="0" end="${applicationScope.VehiclesLength-1}" var="ind" > 
                   <option value="${applicationScope.VehicleIds[ind]}">${applicationScope.Vehicles[ind]}</option>
                    </c:forEach>
                    </select> </p></div>
            
            <div class="fx-col-5" ><p class="w-20">begin:<input name="STAR" type="date"/></p></div>
            <div class="fx-col-5" ><p class="w-20">duur:<input name="DLEN" type="number"/></p>
              
            
            <input name="ORIGIN" type="text" value="RESERVADD" hidden="True">
            <input type="submit"/>
            </div>
        </div>
            
        </form>
            <%@ include file="/footer.jspf" %>
    </body>
</html>
