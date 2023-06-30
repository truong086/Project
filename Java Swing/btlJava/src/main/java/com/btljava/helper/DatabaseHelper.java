/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.helper;

import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author ASUS
 */
public class DatabaseHelper {
    
    // Viết 1 hàm để mở kết nối đến database
    public static Connection getConnection() throws Exception{
        Class.forName("com.mysql.jdbc.Driver");
        String url = "jdbc:mysql://localhost:3306/btl";
        String user = "root";
        String pass = "root";
        Connection con = DriverManager.getConnection(url, user, pass);
        return con;
    }
}
