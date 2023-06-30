/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.Itaikhoan;
import com.btljava.helper.DatabaseHelper;
import com.btljava.helper.MessageDialog;
import com.btljava.model.taikhoan;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class taikhoanDao implements Itaikhoan{
    public boolean insert(taikhoan tk) throws Exception{
        String sql = "insert into taikhoan(tentaikhoan, matkhau, phanquyen) values (?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, tk.getTentaikhoan());
            stmt.setString(2, tk.getMatkhau());
            stmt.setInt(3, tk.getPhanquyen());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean update(taikhoan tk) throws Exception{
        String sql = "update taikhoan set tentaikhoan = ?, matkhau = ?, phanquyen = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, tk.getTentaikhoan());
            stmt.setString(2, tk.getMatkhau());
            stmt.setInt(3, tk.getPhanquyen());
            stmt.setInt(4, tk.getId());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean doimatkhau(taikhoan tk) throws Exception{
        String sql = "update taikhoan set matkhau = ?, phanquyen = ? where tentaikhoan = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(3, tk.getTentaikhoan());
            stmt.setString(1, tk.getMatkhau());
            stmt.setInt(2, tk.getPhanquyen());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean delete(String tk) throws Exception{
        String sql = "delete from taikhoan where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, tk);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    
    public boolean deleteName(String tk) throws Exception{
        String sql = "delete from taikhoan where tentaikhoan = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, tk);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public List<taikhoan> findAll() throws Exception{
        String sql = "select * from taikhoan";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<taikhoan> list = new ArrayList<>();
                while(rs.next()){
                    taikhoan tk = new taikhoan();
                    tk.setId(rs.getInt("id"));
                    tk.setTentaikhoan(rs.getInt("tentaikhoan"));
                    tk.setMatkhau(rs.getString("matkhau"));
                    tk.setPhanquyen(rs.getInt("phanquyen"));
                    list.add(tk);
                }
                return list;
            }
        }
    }
    
    public taikhoan tentaikhoan(int s) throws Exception{
        String sql = "select * from taikhoan where tentaikhoan = " + s + "";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            //stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    taikhoan tk = new taikhoan();
                    tk.setId(rs.getInt("id"));
                    tk.setTentaikhoan(rs.getInt("tentaikhoan"));
                    tk.setMatkhau(rs.getString("matkhau"));
                    tk.setPhanquyen(rs.getInt("phanquyen"));
                    return tk;
                }
                
            }
            return null;
        }
    }
    
    public List<taikhoan> tinkiem(String tks) throws Exception{
        String sql = "select * from taikhoan where tentaikhoan like N'%" + tks + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            try(ResultSet rs = stmt.executeQuery();){
                List<taikhoan> list = new ArrayList<>();
                while(rs.next()){
                    taikhoan tk = new taikhoan();
                    tk.setId(rs.getInt("id"));
                    tk.setTentaikhoan(rs.getInt("tentaikhoan"));
                    tk.setMatkhau(rs.getString("matkhau"));
                    tk.setPhanquyen(rs.getInt("phanquyen"));
                    list.add(tk);
                }
                return list;
            }
        }
    }
    
    public taikhoan findbyid(String tks) throws Exception{
        String sql = "select * from taikhoan where tentaikhoan = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, tks);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    taikhoan tk = new taikhoan();
                    tk.setId(rs.getInt("id"));
                    tk.setTentaikhoan(rs.getInt("tentaikhoan"));
                    tk.setMatkhau(rs.getString("matkhau"));
                    tk.setPhanquyen(rs.getInt("phanquyen"));
                    return tk;
                }
            }
            return null;
        }
    }
    
    public taikhoan findbyids(int tks) throws Exception{
        String sql = "select * from taikhoan where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, tks);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    taikhoan tk = new taikhoan();
                    tk.setId(rs.getInt("id"));
                    tk.setTentaikhoan(rs.getInt("tentaikhoan"));
                    tk.setMatkhau(rs.getString("matkhau"));
                    tk.setPhanquyen(rs.getInt("phanquyen"));
                    return tk;
                }
            }
            return null;
        }
    }
    
    public taikhoan login(String use, String pass) throws Exception{
        int uses = 0;
        uses = Integer.parseInt(use);
        String sql = "select * from taikhoan as tk left join nhanvien as nv on tk.tentaikhoan = nv.manhanvien left join benhnhan as bn on tk.tentaikhoan = bn.mabenhnhan where tk.tentaikhoan = ? and tk.matkhau = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, uses);
            stmt.setString(2, pass);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    taikhoan tk = new taikhoan();
                    tk.setId(rs.getInt("id"));
                    tk.setTentaikhoan(uses);
                    tk.setPhanquyen(rs.getInt("phanquyen"));
              
                    tk.setManhanvien(rs.getInt("manhanvien"));
                    tk.setHotens(rs.getString("hoten"));
                    tk.setNgaysinhs(rs.getString("ngaysinh"));
                    tk.setDiachis(rs.getString("diachi"));
                    tk.setEmail(rs.getString("email"));
                    tk.setGioitinhs(rs.getInt("gioitinh"));
                    tk.setThanhtich(rs.getString("thanhtich"));
                    tk.setNoicongtac(rs.getString("noicongtac"));
                    tk.setChucvu_ids(rs.getInt("chucvu_id"));
                    tk.setNgayvaos(rs.getString("ngayvao"));
                    
                    tk.setMabenhnhan(rs.getInt("bn.mabenhnhan"));
                    tk.setHoten(rs.getString("bn.hoten"));
                    tk.setNgaysinh(rs.getString("bn.ngaysinh"));
                    tk.setDiachi(rs.getString("bn.diachi"));
                    tk.setGioitinh(rs.getInt("bn.gioitinh"));
                    tk.setNhommau(rs.getString("bn.nhommau"));
                    tk.setTinhtrang(rs.getString("bn.tinhtrang"));
                    tk.setChucvu_id(rs.getInt("bn.chucvu_id"));
                    tk.setDoituong_id(rs.getInt("bn.doituong_id"));
                    tk.setNgayvao(rs.getString("bn.ngayvao"));
                    
                    return tk;
                }
            }
            
        }
        return null;
    }
    
    public taikhoan logins(String use, String pass) throws Exception{
        int uses = 0;
        uses = Integer.parseInt(use);
        String sql = "select * from taikhoan where tentaikhoan = ? and matkhau = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, uses);
            stmt.setString(2, pass);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    taikhoan tk = new taikhoan();
                    tk.setId(rs.getInt("id"));
                    tk.setTentaikhoan(uses);
                    tk.setPhanquyen(rs.getInt("phanquyen"));
                    
                    return tk;
                }
            }
            
        }
        return null;
    }
}
