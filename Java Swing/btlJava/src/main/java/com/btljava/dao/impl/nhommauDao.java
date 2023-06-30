/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.Inhommau;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.nhommau;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class nhommauDao implements Inhommau{
    public boolean insert(nhommau nm) throws Exception{
        String sql = "insert into nhommau(ten, ngaytao) values (?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, nm.getTen());
            stmt.setString(2, nm.getNgaytao());
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    public boolean update(nhommau nm) throws Exception{
        String sql = "update nhommau set ten = ?, ngaytao = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, nm.getTen());
            stmt.setString(2, nm.getNgaytao());
            stmt.setInt(3, nm.getId());
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public boolean delete(String nm) throws Exception{
        String sql = "delete from nhommau where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, nm);
            
            return stmt.executeUpdate() > 0;
            
        }
    }
    
    public List<nhommau> findAll() throws Exception{
        String sql = "select * from nhommau";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<nhommau> list = new ArrayList<>();
                while(rs.next()){
                    nhommau nms = new nhommau();
                    nms.setId(rs.getInt("id"));
                    nms.setTen(rs.getString("ten"));
                    nms.setNgaytao(rs.getString("ngaytao"));
                    list.add(nms);
                }
                return list;
            }
            
        }
    }
    
    public List<nhommau> TimKiem(String s) throws Exception{
        String sql = "select * from nhommau where ten like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<nhommau> list = new ArrayList<>();
                while(rs.next()){
                    nhommau nms = new nhommau();
                    nms.setId(rs.getInt("id"));
                    nms.setTen(rs.getString("ten"));
                    nms.setNgaytao(rs.getString("ngaytao"));
                    list.add(nms);
                }
                return list;
            }
            
        }
    }
    
    public nhommau findAllid(int id) throws Exception{
        String sql = "select * from nhommau where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, id);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    nhommau nms = new nhommau();
                    nms.setId(rs.getInt("id"));
                    nms.setTen(rs.getString("ten"));
                    nms.setNgaytao(rs.getString("ngaytao"));
                    return nms;
                }
            }
            return null;
            
        }
    }
}
