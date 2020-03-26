<?php

/* @Twig/layout.html.twig */
class __TwigTemplate_0ef46ff3e00be850b375145c4de69a72941605b1b30816a42d1a36aa92bc080f extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'head' => array($this, 'block_head'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_994ce7f0e583c001152362e4238435d315fd0b08361a44790413bc544f8fc816 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_994ce7f0e583c001152362e4238435d315fd0b08361a44790413bc544f8fc816->enter($__internal_994ce7f0e583c001152362e4238435d315fd0b08361a44790413bc544f8fc816_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        $__internal_0f914d15ee98b91efff658116f1e08b7e7a31b2777eddb85eb6c92912c88d670 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0f914d15ee98b91efff658116f1e08b7e7a31b2777eddb85eb6c92912c88d670->enter($__internal_0f914d15ee98b91efff658116f1e08b7e7a31b2777eddb85eb6c92912c88d670_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        // line 1
        echo "<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"";
        // line 4
        echo twig_escape_filter($this->env, $this->env->getCharset(), "html", null, true);
        echo "\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>";
        // line 7
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
        <link rel=\"icon\" type=\"image/png\" href=\"";
        // line 8
        echo twig_include($this->env, $context, "@Twig/images/favicon.png.base64");
        echo "\">
        <style>";
        // line 9
        echo twig_include($this->env, $context, "@Twig/exception.css.twig");
        echo "</style>
        ";
        // line 10
        $this->displayBlock('head', $context, $blocks);
        // line 11
        echo "    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">";
        // line 15
        echo twig_include($this->env, $context, "@Twig/images/symfony-logo.svg");
        echo " Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">";
        // line 19
        echo twig_include($this->env, $context, "@Twig/images/icon-book.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">";
        // line 26
        echo twig_include($this->env, $context, "@Twig/images/icon-support.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        ";
        // line 33
        $this->displayBlock('body', $context, $blocks);
        // line 34
        echo "        ";
        echo twig_include($this->env, $context, "@Twig/base_js.html.twig");
        echo "
    </body>
</html>
";
        
        $__internal_994ce7f0e583c001152362e4238435d315fd0b08361a44790413bc544f8fc816->leave($__internal_994ce7f0e583c001152362e4238435d315fd0b08361a44790413bc544f8fc816_prof);

        
        $__internal_0f914d15ee98b91efff658116f1e08b7e7a31b2777eddb85eb6c92912c88d670->leave($__internal_0f914d15ee98b91efff658116f1e08b7e7a31b2777eddb85eb6c92912c88d670_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_0986e7f2cf584ede60ee6d4c74ce690b2bb89c580ba602b527336da3930e8b46 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_0986e7f2cf584ede60ee6d4c74ce690b2bb89c580ba602b527336da3930e8b46->enter($__internal_0986e7f2cf584ede60ee6d4c74ce690b2bb89c580ba602b527336da3930e8b46_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_1893848b07a1ef0b6a4a31fdec4a28faefa54b527ae2990003db6994e5991bb3 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1893848b07a1ef0b6a4a31fdec4a28faefa54b527ae2990003db6994e5991bb3->enter($__internal_1893848b07a1ef0b6a4a31fdec4a28faefa54b527ae2990003db6994e5991bb3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        
        $__internal_1893848b07a1ef0b6a4a31fdec4a28faefa54b527ae2990003db6994e5991bb3->leave($__internal_1893848b07a1ef0b6a4a31fdec4a28faefa54b527ae2990003db6994e5991bb3_prof);

        
        $__internal_0986e7f2cf584ede60ee6d4c74ce690b2bb89c580ba602b527336da3930e8b46->leave($__internal_0986e7f2cf584ede60ee6d4c74ce690b2bb89c580ba602b527336da3930e8b46_prof);

    }

    // line 10
    public function block_head($context, array $blocks = array())
    {
        $__internal_f054b235ee02931e9b013cec19b87add2b8510ffca6fb236276a55d35931ba55 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f054b235ee02931e9b013cec19b87add2b8510ffca6fb236276a55d35931ba55->enter($__internal_f054b235ee02931e9b013cec19b87add2b8510ffca6fb236276a55d35931ba55_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_a9861aac9dcfa2f261650f6d807c2c641b51e05e2b28a4dbec2e320d22ec5982 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a9861aac9dcfa2f261650f6d807c2c641b51e05e2b28a4dbec2e320d22ec5982->enter($__internal_a9861aac9dcfa2f261650f6d807c2c641b51e05e2b28a4dbec2e320d22ec5982_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        
        $__internal_a9861aac9dcfa2f261650f6d807c2c641b51e05e2b28a4dbec2e320d22ec5982->leave($__internal_a9861aac9dcfa2f261650f6d807c2c641b51e05e2b28a4dbec2e320d22ec5982_prof);

        
        $__internal_f054b235ee02931e9b013cec19b87add2b8510ffca6fb236276a55d35931ba55->leave($__internal_f054b235ee02931e9b013cec19b87add2b8510ffca6fb236276a55d35931ba55_prof);

    }

    // line 33
    public function block_body($context, array $blocks = array())
    {
        $__internal_66cf2a59b9dfeb2354ec88ad68202cca4762f79d040ca0831503becccc5d2d83 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_66cf2a59b9dfeb2354ec88ad68202cca4762f79d040ca0831503becccc5d2d83->enter($__internal_66cf2a59b9dfeb2354ec88ad68202cca4762f79d040ca0831503becccc5d2d83_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_483906f17d2d02b9b81723cb90eae0c5862f1f3385810908507295a6774b8c1a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_483906f17d2d02b9b81723cb90eae0c5862f1f3385810908507295a6774b8c1a->enter($__internal_483906f17d2d02b9b81723cb90eae0c5862f1f3385810908507295a6774b8c1a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        
        $__internal_483906f17d2d02b9b81723cb90eae0c5862f1f3385810908507295a6774b8c1a->leave($__internal_483906f17d2d02b9b81723cb90eae0c5862f1f3385810908507295a6774b8c1a_prof);

        
        $__internal_66cf2a59b9dfeb2354ec88ad68202cca4762f79d040ca0831503becccc5d2d83->leave($__internal_66cf2a59b9dfeb2354ec88ad68202cca4762f79d040ca0831503becccc5d2d83_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/layout.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  137 => 33,  120 => 10,  103 => 7,  88 => 34,  86 => 33,  76 => 26,  66 => 19,  59 => 15,  53 => 11,  51 => 10,  47 => 9,  43 => 8,  39 => 7,  33 => 4,  28 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"{{ _charset }}\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>{% block title %}{% endblock %}</title>
        <link rel=\"icon\" type=\"image/png\" href=\"{{ include('@Twig/images/favicon.png.base64') }}\">
        <style>{{ include('@Twig/exception.css.twig') }}</style>
        {% block head %}{% endblock %}
    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">{{ include('@Twig/images/symfony-logo.svg') }} Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-book.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-support.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        {% block body %}{% endblock %}
        {{ include('@Twig/base_js.html.twig') }}
    </body>
</html>
", "@Twig/layout.html.twig", "C:\\Projects\\Software-Technologies\\Exam-3-Jan-2018\\Skeletons\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\layout.html.twig");
    }
}
