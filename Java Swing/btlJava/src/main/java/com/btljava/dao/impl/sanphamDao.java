/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.ISanPham;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.sanpham;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class sanphamDao implements ISanPham{
    public boolean insert(sanpham sp) throws Exception{
        String sql = "insert into sanpham(tensanpham, loaisanpham_id, mieuta, giaban, ngaytao) values(?, ?, ?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, sp.getTensanpham());
            stmt.setInt(2, sp.getLoaisanpham_id());
            stmt.setString(3, sp.getMieuta());
            stmt.setInt(4, sp.getGiaban());
            stmt.setString(5, sp.getNgaytao());
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public boolean update(sanpham sp) throws Exception{
        String sql = "update sanpham set tensanpham = ?, loaisanpham_id = ?, mieuta = ?, giaban = ?, ngaytao = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, sp.getTensanpham());
            stmt.setInt(2, sp.getLoaisanpham_id());
            stmt.setString(3, sp.getMieuta());
            stmt.setInt(4, sp.getGiaban());
            stmt.setString(5, sp.getNgaytao());
            stmt.setInt(6, sp.getId());
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public boolean delete(String sp) throws Exception{
        String sql = "delete from sanpham where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setString(1, sp);
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public List<sanpham> findAll() throws Exception{
        String sql = "select * from sanpham";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<sanpham> list = new ArrayList<>();
                while(rs.next()){
                    sanpham sp = new sanpham();
                    sp.setId(rs.getInt("id"));
                    sp.setTensanpham(rs.getString("tensanpham"));
                    sp.setLoaisanpham_id(rs.getInt("loaisanpham_id"));
                    sp.setMieuta(rs.getString("mieuta"));
                    sp.setGiaban(rs.getInt("giaban"));
                    sp.setNgaytao(rs.getString("ngaytao"));
                    list.add(sp);
                }
                return list;
            }
            
        }
    }
    
    public List<sanpham> timkiem(String s) throws Exception{
        String sql = "select * from sanpham where tensanpham like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<sanpham> list = new ArrayList<>();
                while(rs.next()){
                    sanpham sp = new sanpham();
                    sp.setId(rs.getInt("id"));
                    sp.setTensanpham(rs.getString("tensanpham"));
                    sp.setLoaisanpham_id(rs.getInt("loaisanpham_id"));
                    sp.setMieuta(rs.getString("mieuta"));
                    sp.setGiaban(rs.getInt("giaban"));
                    sp.setNgaytao(rs.getString("ngaytao"));
                    list.add(sp);
                }
                return list;
            }
            
        }
    }
    
    public sanpham findby(int s) throws Exception{
        String sql = "select * from sanpham where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    sanpham sp = new sanpham();
                    sp.setId(rs.getInt("id"));
                    sp.setTensanpham(rs.getString("tensanpham"));
                    sp.setLoaisanpham_id(rs.getInt("loaisanpham_id"));
                    sp.setMieuta(rs.getString("mieuta"));
                    sp.setGiaban(rs.getInt("giaban"));
                    sp.setNgaytao(rs.getString("ngaytao"));
                    return sp;
                }
                
            }
            
            return null;
            
        }
    }
}
