<?php
    setcookie("status", "test", time() - 10, "/");
    // Muốn xóa thì để thời gian quá hạn là "-10" (có thể thay thế số bất kỳ), để thời gian là "-10" như vậy là quay về thời gian quá khứ sẽ xóa được
    // Muốn xóa thì là "time() - 10 (hoặc 1 con số bất kỳ là nó sẽ về thời gian trong quá khứ là sẽ xóa được)"
?>