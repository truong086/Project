/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.Ichucvu;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.chucvu;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class chucvuDao implements Ichucvu{
    public boolean insert(chucvu cv) throws Exception{
        String sql = "insert into chucvu(machucvu, tenchucvu, ngaytao, tienluong_id, khenthuong) values (?, ?, ?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, cv.getMachucvu());
            stmt.setString(2, cv.getTenchucvu());
            stmt.setString(3, cv.getNgaytao());
            stmt.setInt(4, cv.getTienluong_id());
            stmt.setInt(5, cv.getKhenthuong());
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
     public boolean update(chucvu cv) throws Exception{
        String sql = "update chucvu set machucvu = ?, tenchucvu = ?, ngaytao = ?, tienluong_id = ?, khenthuong = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, cv.getMachucvu());
            stmt.setString(2, cv.getTenchucvu());
            stmt.setString(3, cv.getNgaytao());
            stmt.setInt(4, cv.getTienluong_id());
            stmt.setInt(5, cv.getKhenthuong());
            stmt.setInt(6, cv.getId());
            
            return stmt.executeUpdate() > 0;
            
        }
    }
     
      public boolean delete(String id) throws Exception{
        String sql = "delete from chucvu where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, id);
            
            return stmt.executeUpdate() > 0;
            
        }
    }
      
       public List<chucvu> findAll() throws Exception{
        String sql = "select * from chucvu";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<chucvu> list = new ArrayList<>();
                while(rs.next()){
                    chucvu cv = new chucvu();
                    cv.setId(rs.getInt("id"));
                    cv.setMachucvu(rs.getInt("machucvu"));
                    cv.setTenchucvu(rs.getString("tenchucvu"));
                    cv.setNgaytao(rs.getString("ngaytao"));
                    cv.setTienluong_id(rs.getInt("tienluong_id"));
                    cv.setKhenthuong(rs.getInt("khenthuong"));
                    list.add(cv);
                }
                return list;
            }
            
        }
    }
       
       public List<chucvu> timkiem( String s) throws Exception{
        String sql = "select * from chucvu where tenchucvu like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<chucvu> list = new ArrayList<>();
                while(rs.next()){
                    chucvu cv = new chucvu();
                    cv.setId(rs.getInt("id"));
                    cv.setMachucvu(rs.getInt("machucvu"));
                    cv.setTenchucvu(rs.getString("tenchucvu"));
                    cv.setNgaytao(rs.getString("ngaytao"));
                    cv.setTienluong_id(rs.getInt("tienluong_id"));
                    cv.setKhenthuong(rs.getInt("khenthuong"));
                    list.add(cv);
                }
                return list;
            }
            
        }
    }
       
       public chucvu findAllid(int n) throws Exception{
        String sql = "select * from chucvu where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, n);
            
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    chucvu cv = new chucvu();
                    cv.setId(rs.getInt("id"));
                    cv.setMachucvu(rs.getInt("machucvu"));
                    cv.setTenchucvu(rs.getString("tenchucvu"));
                    cv.setNgaytao(rs.getString("ngaytao"));
                    cv.setTienluong_id(rs.getInt("tienluong_id"));
                    cv.setKhenthuong(rs.getInt("khenthuong"));
                    return cv;
                }
                
            }
            return null;
            
        }
    }
       
       public chucvu findAllids(int n) throws Exception{
        String sql = "select * from chucvu where machucvu = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, n);
            
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    chucvu cv = new chucvu();
                    cv.setId(rs.getInt("id"));
                    cv.setMachucvu(rs.getInt("machucvu"));
                    cv.setTenchucvu(rs.getString("tenchucvu"));
                    cv.setNgaytao(rs.getString("ngaytao"));
                    cv.setTienluong_id(rs.getInt("tienluong_id"));
                    cv.setKhenthuong(rs.getInt("khenthuong"));
                    return cv;
                }
                
            }
            return null;
            
        }
    }
}
