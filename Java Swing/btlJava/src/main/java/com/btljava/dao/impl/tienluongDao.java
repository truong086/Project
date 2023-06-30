/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.Itienluong;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.tienluong;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class tienluongDao implements Itienluong{
    public boolean insert(tienluong tl) throws Exception{
        String sql = "insert into tienluong(matienluong, tienluong, ngaycong, ngaytao) values (?, ?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, tl.getMatienluong());
            stmt.setInt(2, tl.getTienluong());
            stmt.setInt(3, tl.getNgaycong());
            stmt.setString(4, tl.getNgaytao());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean update(tienluong tl) throws Exception{
        String sql = "update tienluong set matienluong = ?, tienluong = ?, ngaycong = ?, ngaytao = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, tl.getMatienluong());
            stmt.setInt(2, tl.getTienluong());
            stmt.setInt(3, tl.getNgaycong());
            stmt.setString(4, tl.getNgaytao());
            stmt.setInt(5, tl.getId());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean delete(String tl) throws Exception{
        String sql = "delete from tienluong where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, tl);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public List<tienluong> findAll() throws Exception{
        String sql = "select * from tienluong";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<tienluong> list = new ArrayList<>();
                while(rs.next()){
                    tienluong tl = new tienluong();
                    tl.setId(rs.getInt("id"));
                    tl.setMatienluong(rs.getInt("matienluong"));
                    tl.setTienluong(rs.getInt("tienluong"));
                    tl.setNgaycong(rs.getInt("ngaycong"));
                    tl.setNgaytao(rs.getString("ngaytao"));
                    list.add(tl);
                }
                return list;
            }
        }
    }
    
    public List<tienluong> timkiem(String s) throws Exception{
        String sql = "select * from tienluong where matienluong like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<tienluong> list = new ArrayList<>();
                while(rs.next()){
                    tienluong tl = new tienluong();
                    tl.setId(rs.getInt("id"));
                    tl.setMatienluong(rs.getInt("matienluong"));
                    tl.setTienluong(rs.getInt("tienluong"));
                    tl.setNgaycong(rs.getInt("ngaycong"));
                    tl.setNgaytao(rs.getString("ngaytao"));
                    list.add(tl);
                }
                return list;
            }
        }
    }
    
    public tienluong findby(String s) throws Exception{
        String sql = "select * from tienluong where matienluong = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    tienluong tl = new tienluong();
                    tl.setId(rs.getInt("id"));
                    tl.setMatienluong(rs.getInt("matienluong"));
                    tl.setTienluong(rs.getInt("tienluong"));
                    tl.setNgaycong(rs.getInt("ngaycong"));
                    tl.setNgaytao(rs.getString("ngaytao"));
                    return tl;
                }
                
            }
            return null;
        }
    }
    
    public tienluong findbyid(int s) throws Exception{
        String sql = "select * from tienluong where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    tienluong tl = new tienluong();
                    tl.setId(rs.getInt("id"));
                    tl.setMatienluong(rs.getInt("matienluong"));
                    tl.setTienluong(rs.getInt("tienluong"));
                    tl.setNgaycong(rs.getInt("ngaycong"));
                    tl.setNgaytao(rs.getString("ngaytao"));
                    return tl;
                }
                
            }
            return null;
        }
    }
}
