/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.IGiuongNgu;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.giuongngu;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class giuongnguDao implements IGiuongNgu{
    public boolean insert(giuongngu gn) throws Exception{
        String sql = "insert into giuongngu(giuong_id, benhnhan_id, thoigiannam, thoigianra) values (?, ?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, gn.getGiuong_id());
            stmt.setInt(2, gn.getBenhnhan_id());
            stmt.setString(3, gn.getThoigiannam());
            stmt.setString(4, gn.getThoigianra());
            
            return stmt.executeUpdate() > 0;
         }
    }
    
    public boolean update(giuongngu gn) throws Exception{
        String sql = "update giuongngu set giuong_id = ?, benhnhan_id = ?, thoigiannam = ?, thoigianra = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, gn.getGiuong_id());
            stmt.setInt(2, gn.getBenhnhan_id());
            stmt.setString(3, gn.getThoigiannam());
            stmt.setString(4, gn.getThoigianra());
            stmt.setInt(5, gn.getId());
            
            return stmt.executeUpdate() > 0;
         }
    }
    
    public boolean delete(String gn) throws Exception{
        String sql = "delete from giuongngu where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, gn);
            
            return stmt.executeUpdate() > 0;
         }
    }
    
    public List<giuongngu> findAll() throws Exception{
        String sql = "select * from giuongngu";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<giuongngu> list = new ArrayList<>();
                while(rs.next()){
                    giuongngu ng = new giuongngu();
                    ng.setId(rs.getInt("id"));
                    ng.setGiuong_id(rs.getInt("giuong_id"));
                    ng.setBenhnhan_id(rs.getInt("benhnhan_id"));
                    ng.setThoigiannam(rs.getString("thoigiannam"));
                    ng.setThoigianra(rs.getString("thoigianra"));
                    list.add(ng);
                }
                return list;
            }
         }
    }
    
    public List<giuongngu> timkiem(String s) throws Exception{
        String sql = "select * from giuongngu where benhnhan_id like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<giuongngu> list = new ArrayList<>();
                while(rs.next()){
                    giuongngu ng = new giuongngu();
                    ng.setId(rs.getInt("id"));
                    ng.setGiuong_id(rs.getInt("giuong_id"));
                    ng.setBenhnhan_id(rs.getInt("benhnhan_id"));
                    ng.setThoigiannam(rs.getString("thoigiannam"));
                    ng.setThoigianra(rs.getString("thoigianra"));
                    list.add(ng);
                }
                return list;
            }
         }
    }
    
    public giuongngu findbyid(int s) throws Exception{
        String sql = "select * from giuongngu where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    giuongngu ng = new giuongngu();
                    ng.setId(rs.getInt("id"));
                    ng.setGiuong_id(rs.getInt("giuong_id"));
                    ng.setBenhnhan_id(rs.getInt("benhnhan_id"));
                    ng.setThoigiannam(rs.getString("thoigiannam"));
                    ng.setThoigianra(rs.getString("thoigianra"));
                    return ng;
                }
                
            }
            return null;
         }
    }
}
