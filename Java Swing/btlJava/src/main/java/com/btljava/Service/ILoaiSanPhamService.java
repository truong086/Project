/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service;

import com.btljava.model.loaisanpham;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface ILoaiSanPhamService {
    public boolean insert(loaisanpham lsp) throws Exception;
    
    public boolean update(loaisanpham lsp) throws Exception;
    public boolean delete(String lsp) throws Exception;
    
    public List<loaisanpham> findAll() throws Exception;
    
    public List<loaisanpham> finbyid(String s) throws Exception;
    
    public loaisanpham finbyids(int s) throws Exception;
}
