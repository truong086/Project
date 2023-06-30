/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.dao.impl;

import com.btljava.daos.IKKho;
import com.btljava.helper.DatabaseHelper;
import com.btljava.model.kho;
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
public class khoDao implements IKKho{
    @Override
    public boolean insert(kho kh) throws Exception{
        String sql = "insert into kho(sanppham_id, soluong, soluongnhap, daban, tonkho, ngaytao) values (?, ?, ?, ?, ?, ?)";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, kh.getSanpham_id());
            stmt.setInt(2, kh.getSoluong());
            stmt.setInt(3, kh.getSoluongnhap());
            stmt.setInt(4, kh.getDaban());
            stmt.setInt(5, kh.getTonkho());
            stmt.setString(6, kh.getNgaytao());
            
            return stmt.executeUpdate() > 0;
        }
    }
    @Override
    public boolean update(kho kh) throws Exception{
        String sql = "update kho set sanppham_id = ?, soluong = ?, soluongnhap = ?, daban = ?, tonkho = ?, ngaytao = ? where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, kh.getSanpham_id());
            stmt.setInt(2, kh.getSoluong());
            stmt.setInt(3, kh.getSoluongnhap());
            stmt.setInt(4, kh.getDaban());
            stmt.setInt(5, kh.getTonkho());
            stmt.setString(6, kh.getNgaytao());
            stmt.setInt(7, kh.getId());
            
            return stmt.executeUpdate() > 0;
        }
    }
    @Override
    public boolean delete(String kh) throws Exception{
        String sql = "delete from kho where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setString(1, kh);
            
            return stmt.executeUpdate() > 0;
        }
    }
    @Override
    public List<kho> findAll() throws Exception{
        String sql = "select * from kho as k inner join sanpham as sp on sp.id = k.sanppham_id";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<kho> list = new ArrayList<>();
                while(rs.next()){
                    kho kh = new kho();
                    kh.setId(rs.getInt("k.id"));
                    kh.setSanpham_id(rs.getInt("k.sanppham_id"));
                    kh.setSoluong(rs.getInt("k.soluong"));
                    kh.setSoluongnhap(rs.getInt("k.soluongnhap"));
                    kh.setDaban(rs.getInt("k.daban"));
                    kh.setTonkho(rs.getInt("k.tonkho"));
                    kh.setNgaytao(rs.getString("k.ngaytao"));
                    kh.setIds(rs.getInt("sp.id"));
                    kh.setTensanpham(rs.getString("sp.tensanpham"));
                    kh.setLoaisanpham_id(rs.getInt("sp.loaisanpham_id"));
                    kh.setMieuta(rs.getString("sp.mieuta"));
                    kh.setGiaban(rs.getInt("sp.giaban"));
                    kh.setNgaytaos(rs.getString("sp.ngaytao"));
                    list.add(kh);
                }
                return list;
            }
        }
    }
    @Override
    public List<kho> hienthi(int id) throws Exception{
        String sql = "select * from kho as k left join sanpham as sp on sp.id = k.sanppham_id where k.sanppham_id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            stmt.setInt(1, id);
            try(ResultSet rs = stmt.executeQuery();){
                List<kho> list = new ArrayList<>();
                while(rs.next()){
                    kho kh = new kho();
                    kh.setId(rs.getInt("k.id"));
                    kh.setSanpham_id(rs.getInt("k.sanppham_id"));
                    kh.setSoluong(rs.getInt("k.soluong"));
                    kh.setSoluongnhap(rs.getInt("k.soluongnhap"));
                    kh.setDaban(rs.getInt("k.daban"));
                    kh.setTonkho(rs.getInt("k.tonkho"));
                    kh.setNgaytao(rs.getString("k.ngaytao"));
                    kh.setIds(rs.getInt("sp.id"));
                    kh.setTensanpham(rs.getString("sp.tensanpham"));
                    kh.setLoaisanpham_id(rs.getInt("sp.loaisanpham_id"));
                    kh.setMieuta(rs.getString("sp.mieuta"));
                    kh.setGiaban(rs.getInt("sp.giaban"));
                    kh.setNgaytaos(rs.getString("sp.ngaytao"));
                    list.add(kh);
                }
                return list;
            }
            
        }
    }
    
    
    @Override
    public List<kho> timkiem(String s) throws Exception{
        String sql = "select * from kho where sanppham_id like N'%" + s + "%'";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            try(ResultSet rs = stmt.executeQuery();){
                List<kho> list = new ArrayList<>();
                while(rs.next()){
                    kho kh = new kho();
                    kh.setId(rs.getInt("id"));
                    kh.setSanpham_id(rs.getInt("sanppham_id"));
                    kh.setSoluong(rs.getInt("soluong"));
                    kh.setSoluongnhap(rs.getInt("soluongnhap"));
                    kh.setDaban(rs.getInt("daban"));
                    kh.setTonkho(rs.getInt("tonkho"));
                    kh.setNgaytao(rs.getString("ngaytao"));
                    list.add(kh);
                }
                return list;
            }
        }
    }
    @Override
    public kho findAllid(int s) throws Exception{
        String sql = "select * from kho where id = ?";
        try(
                Connection con = DatabaseHelper.getConnection();
                PreparedStatement stmt = con.prepareStatement(sql);
                ){
            
            stmt.setInt(1, s);
            try(ResultSet rs = stmt.executeQuery();){
                if(rs.next()){
                    kho kh = new kho();
                    kh.setId(rs.getInt("id"));
                    kh.setSanpham_id(rs.getInt("sanppham_id"));
                    kh.setSoluong(rs.getInt("soluong"));
                    kh.setSoluongnhap(rs.getInt("soluongnhap"));
                    kh.setDaban(rs.getInt("daban"));
                    kh.setTonkho(rs.getInt("tonkho"));
                    kh.setNgaytao(rs.getString("ngaytao"));
                    return kh;
                }
                
            }
            return null;
        }
    }

    
}
