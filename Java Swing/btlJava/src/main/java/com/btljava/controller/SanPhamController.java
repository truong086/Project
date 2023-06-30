/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.ISanPhamService;
import com.btljava.Service.Impl.SanPhamService;
import com.btljava.daos.ISanPham;
import com.btljava.dao.impl.sanphamDao;
import com.btljava.model.sanpham;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class SanPhamController {
    private ISanPhamService dao;
    
    public SanPhamController(){
        dao = new SanPhamService();
    }
    
    public boolean insert(sanpham sp) throws Exception {
        return dao.insert(sp);
    }

    
    public boolean update(sanpham sp) throws Exception {
        return dao.update(sp);
    }

    
    public boolean delete(String sp) throws Exception {
        return dao.delete(sp);
    }

    
    public List<sanpham> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<sanpham> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    
    public sanpham findby(int s) throws Exception {
        return dao.findby(s);
    }
}
