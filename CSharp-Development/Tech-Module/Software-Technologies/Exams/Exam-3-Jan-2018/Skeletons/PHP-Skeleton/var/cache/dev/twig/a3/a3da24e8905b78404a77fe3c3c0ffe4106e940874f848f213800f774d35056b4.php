<?php

/* base.html.twig */
class __TwigTemplate_93e2499d03c6402ea1e3906495568257ed0120721f7f5badb0e11600e82927c5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_040f33837e3d31cb272e450534cbab98581d180bd4a4dd907ad7f6a5c2ac4f6c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_040f33837e3d31cb272e450534cbab98581d180bd4a4dd907ad7f6a5c2ac4f6c->enter($__internal_040f33837e3d31cb272e450534cbab98581d180bd4a4dd907ad7f6a5c2ac4f6c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_41e5fb4956652925842a9637219a884b758b3c53fe283567b4528bddaffc9041 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_41e5fb4956652925842a9637219a884b758b3c53fe283567b4528bddaffc9041->enter($__internal_41e5fb4956652925842a9637219a884b758b3c53fe283567b4528bddaffc9041_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>";
        // line 10
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 11
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 20
        $this->displayBlock('body', $context, $blocks);
        // line 23
        echo "</body>
</html>
";
        
        $__internal_040f33837e3d31cb272e450534cbab98581d180bd4a4dd907ad7f6a5c2ac4f6c->leave($__internal_040f33837e3d31cb272e450534cbab98581d180bd4a4dd907ad7f6a5c2ac4f6c_prof);

        
        $__internal_41e5fb4956652925842a9637219a884b758b3c53fe283567b4528bddaffc9041->leave($__internal_41e5fb4956652925842a9637219a884b758b3c53fe283567b4528bddaffc9041_prof);

    }

    // line 10
    public function block_title($context, array $blocks = array())
    {
        $__internal_3206230caaa0bc556bee3a6bc90d4d821be47b49afb777f13f764bb57a4bc3dc = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_3206230caaa0bc556bee3a6bc90d4d821be47b49afb777f13f764bb57a4bc3dc->enter($__internal_3206230caaa0bc556bee3a6bc90d4d821be47b49afb777f13f764bb57a4bc3dc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_ba3292be91cd754c4e8de07edf98cdcb2b8e3727ef9a14ce8ec82c1c28270cba = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ba3292be91cd754c4e8de07edf98cdcb2b8e3727ef9a14ce8ec82c1c28270cba->enter($__internal_ba3292be91cd754c4e8de07edf98cdcb2b8e3727ef9a14ce8ec82c1c28270cba_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Project Rider";
        
        $__internal_ba3292be91cd754c4e8de07edf98cdcb2b8e3727ef9a14ce8ec82c1c28270cba->leave($__internal_ba3292be91cd754c4e8de07edf98cdcb2b8e3727ef9a14ce8ec82c1c28270cba_prof);

        
        $__internal_3206230caaa0bc556bee3a6bc90d4d821be47b49afb777f13f764bb57a4bc3dc->leave($__internal_3206230caaa0bc556bee3a6bc90d4d821be47b49afb777f13f764bb57a4bc3dc_prof);

    }

    // line 11
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_bae776c338c412a10448680c84e4b71a33bb264560edda139f5d8f08af884f4c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_bae776c338c412a10448680c84e4b71a33bb264560edda139f5d8f08af884f4c->enter($__internal_bae776c338c412a10448680c84e4b71a33bb264560edda139f5d8f08af884f4c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_7dd8c705c5e226268041f0bfbad35f59f175507937d79469db9c575a8c74f988 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7dd8c705c5e226268041f0bfbad35f59f175507937d79469db9c575a8c74f988->enter($__internal_7dd8c705c5e226268041f0bfbad35f59f175507937d79469db9c575a8c74f988_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 12
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/reset.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 13
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/create-style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_7dd8c705c5e226268041f0bfbad35f59f175507937d79469db9c575a8c74f988->leave($__internal_7dd8c705c5e226268041f0bfbad35f59f175507937d79469db9c575a8c74f988_prof);

        
        $__internal_bae776c338c412a10448680c84e4b71a33bb264560edda139f5d8f08af884f4c->leave($__internal_bae776c338c412a10448680c84e4b71a33bb264560edda139f5d8f08af884f4c_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_c2eb9e4ff04ae8efe6871b551b9792d31378deb0de8100bac9fcf69d7b59e756 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c2eb9e4ff04ae8efe6871b551b9792d31378deb0de8100bac9fcf69d7b59e756->enter($__internal_c2eb9e4ff04ae8efe6871b551b9792d31378deb0de8100bac9fcf69d7b59e756_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_19bf7889c37cd59c4d5af2e77259ff61a822b07606e34edf319a63b81f54f1d0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_19bf7889c37cd59c4d5af2e77259ff61a822b07606e34edf319a63b81f54f1d0->enter($__internal_19bf7889c37cd59c4d5af2e77259ff61a822b07606e34edf319a63b81f54f1d0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_19bf7889c37cd59c4d5af2e77259ff61a822b07606e34edf319a63b81f54f1d0->leave($__internal_19bf7889c37cd59c4d5af2e77259ff61a822b07606e34edf319a63b81f54f1d0_prof);

        
        $__internal_c2eb9e4ff04ae8efe6871b551b9792d31378deb0de8100bac9fcf69d7b59e756->leave($__internal_c2eb9e4ff04ae8efe6871b551b9792d31378deb0de8100bac9fcf69d7b59e756_prof);

    }

    // line 20
    public function block_body($context, array $blocks = array())
    {
        $__internal_cbb7a7253e8bbd1e2f3ac76a6ad59636679ea562556826af2db2a138e9bfb3a7 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_cbb7a7253e8bbd1e2f3ac76a6ad59636679ea562556826af2db2a138e9bfb3a7->enter($__internal_cbb7a7253e8bbd1e2f3ac76a6ad59636679ea562556826af2db2a138e9bfb3a7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_3c77d6182a4b8fe254ed1b20baf179d4108021ca479268fa2ec8e5d499f89955 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3c77d6182a4b8fe254ed1b20baf179d4108021ca479268fa2ec8e5d499f89955->enter($__internal_3c77d6182a4b8fe254ed1b20baf179d4108021ca479268fa2ec8e5d499f89955_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 21
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_3c77d6182a4b8fe254ed1b20baf179d4108021ca479268fa2ec8e5d499f89955->leave($__internal_3c77d6182a4b8fe254ed1b20baf179d4108021ca479268fa2ec8e5d499f89955_prof);

        
        $__internal_cbb7a7253e8bbd1e2f3ac76a6ad59636679ea562556826af2db2a138e9bfb3a7->leave($__internal_cbb7a7253e8bbd1e2f3ac76a6ad59636679ea562556826af2db2a138e9bfb3a7_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_e320c0a73cc083a4141be370d5666ceaa1158564b2ca0655bb469051d2eee5ad = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e320c0a73cc083a4141be370d5666ceaa1158564b2ca0655bb469051d2eee5ad->enter($__internal_e320c0a73cc083a4141be370d5666ceaa1158564b2ca0655bb469051d2eee5ad_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_66982ac105514e7e6eff7a197449244400cf92eaa85fca4d798ff186dbe81180 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_66982ac105514e7e6eff7a197449244400cf92eaa85fca4d798ff186dbe81180->enter($__internal_66982ac105514e7e6eff7a197449244400cf92eaa85fca4d798ff186dbe81180_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_66982ac105514e7e6eff7a197449244400cf92eaa85fca4d798ff186dbe81180->leave($__internal_66982ac105514e7e6eff7a197449244400cf92eaa85fca4d798ff186dbe81180_prof);

        
        $__internal_e320c0a73cc083a4141be370d5666ceaa1158564b2ca0655bb469051d2eee5ad->leave($__internal_e320c0a73cc083a4141be370d5666ceaa1158564b2ca0655bb469051d2eee5ad_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  141 => 21,  132 => 20,  115 => 19,  103 => 14,  99 => 13,  94 => 12,  85 => 11,  67 => 10,  55 => 23,  53 => 20,  49 => 19,  42 => 16,  40 => 11,  36 => 10,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>{% block title %}Project Rider{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/reset.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/create-style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "C:\\Projects\\Software-Technologies\\Exam-3-Jan-2018\\Skeletons\\PHP-Skeleton\\app\\Resources\\views\\base.html.twig");
    }
}
