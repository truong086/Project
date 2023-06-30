/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.helper;

import java.awt.Color;
import javax.swing.JPasswordField;
import javax.swing.JTextArea;
import javax.swing.JTextField;

/**
 *
 * @author ASUS
 */
public class DataValidor {
    // Viết 1 hàm để kiểm tra xem người dùng có bỏ trống ô text nào không
    public static void kiemtra(JTextField text, StringBuilder bd, String message) {
        // "StringBuilder sb" ở đây nghĩa là chứa thông báo lỗi
        // "String errorMessage" ở đây nghĩa là chuyền thông báo lỗi vào
        if(text.getText().equals("")){ // Nếu người dùng bỏ trống dữ liệu thì thực hiện lệnh bên trong "if"
            bd.append(message).append("\n"); // In ra thông báo lỗi
            text.setBackground(Color.red); // Đổi màu trên ô text sang màu đỏ
            text.requestFocus(); // Chuyền lại con trỏ
        }else{ // Nếu người dùng không để chống thì giữ nguyên màu của ô text
            text.setBackground(Color.WHITE);
        }
    }
    
    public static void kiemtrapass(JPasswordField field, StringBuilder bd, String Message) {
        // Kiểm tra password thì dùng "JPasswordField" để kiểm tra
        String password = new String(field.getPassword());
        if(password.equals("")){
            bd.append(Message).append("\n");
            field.setBackground(Color.red);
            field.requestFocus();
        }else{
            field.setBackground(Color.WHITE);
        }
    }

    public static void kiemtraArea(JTextArea noidungs, StringBuilder sb, String tiêu_đề_không_được_để_trống) {
        if(noidungs.getText().equals("")){ // Nếu người dùng bỏ trống dữ liệu thì thực hiện lệnh bên trong "if"
            sb.append(tiêu_đề_không_được_để_trống).append("\n"); // In ra thông báo lỗi
            noidungs.setBackground(Color.red); // Đổi màu trên ô text sang màu đỏ
            noidungs.requestFocus(); // Chuyền lại con trỏ
        }else{ // Nếu người dùng không để chống thì giữ nguyên màu của ô text
            noidungs.setBackground(Color.WHITE);
        }
    }
}
