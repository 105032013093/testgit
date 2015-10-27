package com.nd.htp.servlets;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class TestServlet extends HttpServlet{
     @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
    		throws ServletException, IOException {
    	 request.setCharacterEncoding("utf-8");
 		response.setCharacterEncoding("utf-8");
 		response.setContentType("text/html; charset=utf-8");
 		response.getOutputStream().write("µÇä›³É¹¦".getBytes("utf-8"));
    	
    }
     
     @Override
    protected void doPost(HttpServletRequest req, HttpServletResponse resp)
    		throws ServletException, IOException {
    	super.doGet(req, resp);
    }
}
