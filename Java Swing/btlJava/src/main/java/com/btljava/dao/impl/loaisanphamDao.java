/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.Iloaisanpham;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.loaisanpham;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class loaisanphamDao implements Iloaisanpham{
    public boolean insert(loaisanpham lsp) throws Exception{
        String sql = "insert into loaisanpham (tenloai, ngaytao) values (?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, lsp.getTenloai());
            stmt.setString(2, lsp.getNgaytao());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean update(loaisanpham lsp) throws Exception{
        String sql = "update loaisanpham set tenloai = ?, ngaytao = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, lsp.getTenloai());
            stmt.setString(2, lsp.getNgaytao());
            stmt.setInt(3, lsp.getId());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean delete(String lsp) throws Exception{
        String sql = "delete from loaisanpham where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, lsp);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public List<loaisanpham> findAll() throws Exception{
        String sql = "select * from loaisanpham";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<loaisanpham> list = new ArrayList<>();
                while(rs.next()){
                    loaisanpham ls = new loaisanpham();
                    ls.setId(rs.getInt("id"));
                    ls.setTenloai(rs.getString("tenloai"));
                    ls.setNgaytao(rs.getString("ngaytao"));
                    list.add(ls);
                }
                return list;
            }
            
        }
    }
    
    public List<loaisanpham> finbyid(String s) throws Exception{
        String sql = "select * from loaisanpham where tenloai like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<loaisanpham> list = new ArrayList<>();
                while(rs.next()){
                    loaisanpham ls = new loaisanpham();
                    ls.setId(rs.getInt("id"));
                    ls.setTenloai(rs.getString("tenloai"));
                    ls.setNgaytao(rs.getString("ngaytao"));
                    list.add(ls);
                }
                return list;
            }
            
        }
    }
    
    public loaisanpham finbyids(int s) throws Exception{
        String sql = "select * from loaisanpham where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    loaisanpham ls = new loaisanpham();
                    ls.setId(rs.getInt("id"));
                    ls.setTenloai(rs.getString("tenloai"));
                    ls.setNgaytao(rs.getString("ngaytao"));
                    return ls;
                }
               
            }
             return null;
            
        }
    }
}
