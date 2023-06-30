/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.ILoaiSanPhamService;
import com.btljava.Service.Impl.LoaiSanPhamServicie;
import com.btljava.daos.Iloaisanpham;
import com.btljava.dao.impl.loaisanphamDao;
import com.btljava.model.loaisanpham;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class LoaiSanPhamController {
    private ILoaiSanPhamService dao;
    
    public LoaiSanPhamController(){
        dao = new LoaiSanPhamServicie();
    }
    
    
    public boolean insert(loaisanpham lsp) throws Exception {
        return dao.insert(lsp);
    }

    
    public boolean update(loaisanpham lsp) throws Exception {
        return dao.update(lsp);
    }

    
    public boolean delete(String lsp) throws Exception {
        return dao.delete(lsp);
    }

    
    public List<loaisanpham> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<loaisanpham> finbyid(String s) throws Exception {
        return dao.finbyid(s);
    }

    
    public loaisanpham finbyids(int s) throws Exception {
        return dao.finbyids(s);
    }
}
