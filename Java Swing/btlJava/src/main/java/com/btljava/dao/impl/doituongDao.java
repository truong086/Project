/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.Idoituong;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.doituong;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class doituongDao implements Idoituong{

    public boolean insert(doituong dt) throws Exception {
        // Viết câu lệnh truy vấn đến sql
        String sql = "insert into doituong(madoituong,tendoituong, ngaythem) values (?, ?, ?)";
        try(
                // Gọi lại chuỗi kết nối đến database
                Connection con = DatabaseHelper.getConnection();
                // Sử lý câu lệnh sql
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            // Chuyền tham số vào để gán vào các dấu "?" ở trên câu lệnh sql để xử lý
            stmt.setInt(1, dt.getMadoituong());
            stmt.setString(2, dt.getTendoituong()); // "1" nghĩa là dấu "?" đầu tiền
            stmt.setString(3, dt.getNgaythem()); // "2" nghĩa là dấu "?" thứ 2
            
            
            
            return stmt.executeUpdate() > 0; // "Thực hiện query
        }
    }

    public boolean update(doituong dt) throws Exception {
        // Viết câu lệnh truy vấn đến sql
        String sql = "update doituong set tendoituong = ?, ngaythem = ? where madoituong = ?";
        try(
                // Gọi lại chuỗi kết nối đến database
                Connection con = DatabaseHelper.getConnection();
                // Sử lý câu lệnh sql
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            // Chuyền tham số vào để gán vào các dấu "?" ở trên câu lệnh sql để xử lý
            stmt.setInt(3, dt.getMadoituong());
            stmt.setString(1, dt.getTendoituong()); // "1" nghĩa là dấu "?" đầu tiền
            stmt.setString(2, dt.getNgaythem()); // "2" nghĩa là dấu "?" thứ 2
            
            
            return stmt.executeUpdate() > 0; // "Thực hiện query
        }
    }

    public boolean delete(String id) throws Exception {
        // Viết câu lệnh truy vấn đến sql
        String sql = "delete from doituong where madoituong = ?";
        try(
                // Gọi lại chuỗi kết nối đến database
                Connection con = DatabaseHelper.getConnection();
                // Sử lý câu lệnh sql
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            // Chuyền tham số vào để gán vào các dấu "?" ở trên câu lệnh sql để xử lý
            stmt.setString(1, id); // "1" nghĩa là dấu "?" đầu tiền
            
            
            return stmt.executeUpdate() > 0; // "Thực hiện query
        }
    }

    public List<doituong> findAll() throws Exception {
        // Viết câu lệnh truy vấn đến sql
        String sql = "select * from doituong";
        try(
                // Gọi lại chuỗi kết nối đến database
                Connection con = DatabaseHelper.getConnection();
                // Sử lý câu lệnh sql
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<doituong> list = new ArrayList<>();
                while(rs.next()){
                    doituong dt = new doituong();
                    dt.setId(rs.getInt("id"));
                    dt.setMadoituong(rs.getInt("madoituong"));
                    dt.setTendoituong(rs.getString("tendoituong"));
                    dt.setNgaythem(rs.getString("ngaythem"));
                    list.add(dt);
                }
                return list;
            }
        }
    }

    public List<doituong> findBy(String id) throws Exception {
        String sql = "select * from doituong where tendoituong like N'%" + id +"%' or madoituong like N'%" + id + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<doituong> list = new ArrayList<>();
                while(rs.next()){
                    doituong dt = new doituong();
                    dt.setId(rs.getInt("id"));
                    dt.setMadoituong(rs.getInt("madoituong"));
                    dt.setTendoituong(rs.getString("tendoituong"));
                    dt.setNgaythem(rs.getString("ngaythem"));
                    list.add(dt);
                }
                return list;
            }
        
        }
    }
    
    
    public doituong findBys(int madoituong) throws Exception{
       String sql = "select * from doituong where madoituong = ?";
       try(
               // Gọi lại chuỗi kết nối đến database
               Connection con = DatabaseHelper.getConnection();
               // Xử lý câu lệnh truy vấn sql
               PreparedStatement stmt = con.prepareStatement(sql);
               ){
               stmt.setInt(1, madoituong);
               
               try(ResultSet rs = stmt.executeQuery();){ // Thực hiện query
                  if(rs.next()){
                    doituong dt = new doituong();
                    dt.setId(rs.getInt("id"));
                    dt.setMadoituong(rs.getInt("madoituong"));
                    dt.setTendoituong(rs.getString("tendoituong"));
                    dt.setNgaythem(rs.getString("ngaythem"));
                    return dt;
                }
            } 
               return null;
       }
    }
    
    public doituong findByss(int madoituong) throws Exception{
       String sql = "select * from doituong where id = ?";
       try(
               // Gọi lại chuỗi kết nối đến database
               Connection con = DatabaseHelper.getConnection();
               // Xử lý câu lệnh truy vấn sql
               PreparedStatement stmt = con.prepareStatement(sql);
               ){
               stmt.setInt(1, madoituong);
               
               try(ResultSet rs = stmt.executeQuery();){ // Thực hiện query
                  if(rs.next()){
                    doituong dt = new doituong();
                    dt.setId(rs.getInt("id"));
                    dt.setMadoituong(rs.getInt("madoituong"));
                    dt.setTendoituong(rs.getString("tendoituong"));
                    dt.setNgaythem(rs.getString("ngaythem"));
                    return dt;
                }
            } 
               return null;
       }
    }
}
