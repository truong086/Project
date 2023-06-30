/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service;

import com.btljava.model.sanpham;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface ISanPhamService {
    public boolean insert(sanpham sp) throws Exception;
    
    public boolean update(sanpham sp) throws Exception;
    
    public boolean delete(String sp) throws Exception;
    
    public List<sanpham> findAll() throws Exception;
    
    public List<sanpham> timkiem(String s) throws Exception;
    
    public sanpham findby(int s) throws Exception;
}
