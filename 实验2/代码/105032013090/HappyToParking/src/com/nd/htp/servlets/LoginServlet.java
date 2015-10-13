package com.nd.htp.servlets;

import java.io.IOException;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.nd.htp.dataOperator.ConnectSelect;
import com.nd.htp.json.JSONObject;

public class LoginServlet extends HttpServlet {
	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		boolean tap = true;
		request.setCharacterEncoding("utf-8");
		response.setCharacterEncoding("utf-8");
		response.setContentType("text/html; charset=utf-8");
		String username = request.getParameter("username");
		String password = request.getParameter("password");

		System.out.println("username:" + username);
		System.out.println("password:" + password);
		ResultSet resultSet = null;
		Connection connection = null;
		Statement statement = null;
		try {
			String sql = "select * from user";
			resultSet = ConnectSelect.conn_mysql(sql, connection, statement,
					resultSet);
			JSONObject object = new JSONObject();
			String usernameServer, passwordServer;
			while (resultSet.next()) {
				usernameServer = resultSet.getString("username");
				passwordServer = resultSet.getString("password");
				System.out.println(usernameServer + "\t" + passwordServer
						+ "\n");
				if (username.equals(usernameServer)
						& password.equals(passwordServer)) {
					object.put("success", "µÇÂ¼³É¹¦");
					object.put("user_id", resultSet.getString("userId"));
					tap = false;
					break;
				}
			}
			if (tap) {
				System.out.println("µÇÂ¼Ê§°Ü");
			} else {
				response.getOutputStream().write(
						(object.toString()).getBytes("utf-8"));
			}
//			resultSet.close();
//			statement.close();
//			connection.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		super.doGet(request, response);
	}
}
