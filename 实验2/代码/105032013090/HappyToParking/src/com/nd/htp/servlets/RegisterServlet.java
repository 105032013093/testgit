package com.nd.htp.servlets;

import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.nd.htp.dataOperator.ConnectSelect;
import com.nd.htp.dataOperator.ConnectUpdate;
import com.nd.htp.json.JSONObject;

public class RegisterServlet extends HttpServlet {

	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		request.setCharacterEncoding("utf-8");
		response.setCharacterEncoding("utf-8");
		response.setContentType("text/html; charset=utf-8");
		String username = request.getParameter("username");
		String password = request.getParameter("password");
		String phone = request.getParameter("phone");
		System.out.println("username:" + username);
		System.out.println("password:" + password);
		System.out.println("phone:" + phone);
		int resultSet = 0;
		Connection connection = null;
		PreparedStatement statement = null;

		try {
			if (username.equals("") || password.equals("") || phone.equals("")) {
				System.out.println("插入失败");
				response.getOutputStream().write("注册失败".getBytes("utf-8"));
			} else {
				String sql = "insert into user (username,password) values ("
						+ "'" + username + "'" + "," + "'" + password + "'"
						+ ")";
				resultSet = ConnectUpdate.coon_update(sql, connection,
						statement);
				System.out.println(resultSet);
				if (resultSet > 0) {
					System.out.println("插入成功");
					response.getOutputStream().write("注册成功".getBytes("utf-8"));
				}

			}
			statement.close();
			connection.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		super.doGet(request, response);
	}
}
