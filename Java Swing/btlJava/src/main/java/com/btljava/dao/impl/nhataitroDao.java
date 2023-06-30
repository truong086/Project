/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.INhaTaiTro;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.nhataitro;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class nhataitroDao implements INhaTaiTro{
    public boolean insert(nhataitro ntt) throws Exception{
        String sql = "insert into nhataitro(manhataitro, hoten, ngaysinh, diachi, email, gioitinh, sodienthoai, tinhtrangbenh, taitro, ngaytao) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt  = con.prepareStatement(sql);
                ){
            stmt.setInt(1, ntt.getManhataitro());
            stmt.setString(2, ntt.getHoten());
            stmt.setString(3, ntt.getNgaysinh());
            stmt.setString(4, ntt.getDiachi());
            stmt.setString(5, ntt.getEmail());
            stmt.setInt(6, ntt.getGioitinh());
            stmt.setString(7, ntt.getSodienthoai());
            stmt.setString(8, ntt.getTinhtrangbenh());
            stmt.setString(9, ntt.getTaitro());
            stmt.setString(10, ntt.getNgaytao());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean update(nhataitro ntt) throws Exception{
        String sql = "update nhataitro set manhataitro = ?, hoten = ?, ngaysinh = ?, diachi = ?, email = ?, gioitinh = ?, sodienthoai = ?, tinhtrangbenh = ?, taitro = ?, ngaytao = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt  = con.prepareStatement(sql);
                ){
            stmt.setInt(1, ntt.getManhataitro());
            stmt.setString(2, ntt.getHoten());
            stmt.setString(3, ntt.getNgaysinh());
            stmt.setString(4, ntt.getDiachi());
            stmt.setString(5, ntt.getEmail());
            stmt.setInt(6, ntt.getGioitinh());
            stmt.setString(7, ntt.getSodienthoai());
            stmt.setString(8, ntt.getTinhtrangbenh());
            stmt.setString(9, ntt.getTaitro());
            stmt.setString(10, ntt.getNgaytao());
            stmt.setInt(11, ntt.getId());
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public boolean delet(String ntt) throws Exception{
        String sql = "delete from nhataitro where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt  = con.prepareStatement(sql);
                ){
            stmt.setString(1, ntt);
            
            return stmt.executeUpdate() > 0;
        }
    }
    
    public List<nhataitro> findAll() throws Exception{
        String sql = "select * from nhataitro";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt  = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<nhataitro> list = new ArrayList<>();
                while(rs.next()){
                    nhataitro ntt = new nhataitro();
                    ntt.setId(rs.getInt("id"));
                    ntt.setManhataitro(rs.getInt("manhataitro"));
                    ntt.setHoten(rs.getString("hoten"));
                    ntt.setNgaysinh(rs.getString("ngaysinh"));
                    ntt.setDiachi(rs.getString("diachi"));
                    ntt.setEmail(rs.getString("email"));
                    ntt.setGioitinh(rs.getInt("gioitinh"));
                    ntt.setSodienthoai(rs.getString("sodienthoai"));
                    ntt.setTinhtrangbenh(rs.getString("tinhtrangbenh"));
                    ntt.setTaitro(rs.getString("taitro"));
                    ntt.setNgaytao(rs.getString("ngaytao"));
                    list.add(ntt);
                }
                return list;
            }
        }
    }
    
    public List<nhataitro> timkiem(String s) throws Exception{
        String sql = "select * from nhataitro where manhataitro like N'%" + s + "%' or hoten like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt  = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<nhataitro> list = new ArrayList<>();
                while(rs.next()){
                    nhataitro ntt = new nhataitro();
                    ntt.setId(rs.getInt("id"));
                    ntt.setManhataitro(rs.getInt("manhataitro"));
                    ntt.setHoten(rs.getString("hoten"));
                    ntt.setNgaysinh(rs.getString("ngaysinh"));
                    ntt.setDiachi(rs.getString("diachi"));
                    ntt.setEmail(rs.getString("email"));
                    ntt.setGioitinh(rs.getInt("gioitinh"));
                    ntt.setSodienthoai(rs.getString("sodienthoai"));
                    ntt.setTinhtrangbenh(rs.getString("tinhtrangbenh"));
                    ntt.setTaitro(rs.getString("taitro"));
                    ntt.setNgaytao(rs.getString("ngaytao"));
                    list.add(ntt);
                }
                return list;
            }
        }
    }
    
    public nhataitro findbyid(int s) throws Exception{
        String sql = "select * from nhataitro where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt  = con.prepareStatement(sql);
                ){
            stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    nhataitro ntt = new nhataitro();
                    ntt.setId(rs.getInt("id"));
                    ntt.setManhataitro(rs.getInt("manhataitro"));
                    ntt.setHoten(rs.getString("hoten"));
                    ntt.setNgaysinh(rs.getString("ngaysinh"));
                    ntt.setDiachi(rs.getString("diachi"));
                    ntt.setEmail(rs.getString("email"));
                    ntt.setGioitinh(rs.getInt("gioitinh"));
                    ntt.setSodienthoai(rs.getString("sodienthoai"));
                    ntt.setTinhtrangbenh(rs.getString("tinhtrangbenh"));
                    ntt.setTaitro(rs.getString("taitro"));
                    ntt.setNgaytao(rs.getString("ngaytao"));
                    return ntt;
                }
                
            }
            return null;
        }
    }
    
    public nhataitro findbyntt(String s) throws Exception{
        String sql = "select * from nhataitro where manhataitro = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt  = con.prepareStatement(sql);
                ){
            stmt.setString(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    nhataitro ntt = new nhataitro();
                    ntt.setId(rs.getInt("id"));
                    ntt.setManhataitro(rs.getInt("manhataitro"));
                    ntt.setHoten(rs.getString("hoten"));
                    ntt.setNgaysinh(rs.getString("ngaysinh"));
                    ntt.setDiachi(rs.getString("diachi"));
                    ntt.setEmail(rs.getString("email"));
                    ntt.setGioitinh(rs.getInt("gioitinh"));
                    ntt.setSodienthoai(rs.getString("sodienthoai"));
                    ntt.setTinhtrangbenh(rs.getString("tinhtrangbenh"));
                    ntt.setTaitro(rs.getString("taitro"));
                    ntt.setNgaytao(rs.getString("ngaytao"));
                    return ntt;
                }
                
            }
            return null;
        }
    }
}
