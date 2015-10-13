package com.nd.htp.serversocket;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

import javax.swing.JOptionPane;


public class ServerListener extends Thread {
	public void run() {

		try {
			ServerSocket serverSocket=new ServerSocket(12345);
			while(true){
			//block
			Socket socket=serverSocket.accept();
			//建立连接
			JOptionPane.showMessageDialog(null, "有客户端连接到了本机的12345端口");
			//将socket传递给新的线程
			ChatSocket cs=new ChatSocket(socket);
			cs.start();
	//		ChatManager.getchChatManager().add(cs);
			}
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
