/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.ui;

import java.util.regex.Pattern;

/**
 *
 * @author ASUS
 */
public class tetstss {
    
    // Kiểm tra emailtheo đúng định dạng của chuẩn "RFC"
    public static void main(String[] args) throws Exception {
        String emailAddress = "username@domain.com";
        String regexPattern = "^[a-zA-Z0-9_!#$%&'*+/=?`{|}~^.-]+@[a-zA-Z0-9.-]+$";
        if(patternMatches(emailAddress, regexPattern)) {
        	System.out.println("Đúng định dạng ");
        }else{
            System.out.println("Không đúng định dạng");
        }
        
    }
    public static boolean patternMatches(String emailAddress, String regexPattern) {
        return Pattern.compile(regexPattern)
                .matcher(emailAddress)
                .matches();
    }
}
